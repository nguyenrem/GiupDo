using Microsoft.AspNetCore.Authorization;
using remproject.Admin.Catalog.ProductAttributes;
using remproject.ProductAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using remproject.Admin.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace remproject.Admin.ProductAttributes
{
    [Authorize(remprojectPermissions.Attribute.Default, Policy = "AdminOnly")]
    public class ProductAttributesAppService : CrudAppService<
        ProductAttribute,
        ProductAttributeDto,
        Guid,
        PagedResultRequestDto,
        CreateUpdateProductAttributeDto,
        CreateUpdateProductAttributeDto>, IProductAttributesAppService
    {
        public ProductAttributesAppService(IRepository<ProductAttribute, Guid> repository)
            : base(repository)
        {
            GetPolicyName = remprojectPermissions.Attribute.Default;
            GetListPolicyName = remprojectPermissions.Attribute.Default;
            CreatePolicyName = remprojectPermissions.Attribute.Create;
            UpdatePolicyName = remprojectPermissions.Attribute.Update;
            DeletePolicyName = remprojectPermissions.Attribute.Delete;
        }

        [Authorize(remprojectPermissions.Attribute.Delete)]
        public async Task DeleteMultipleAsync(IEnumerable<Guid> ids)
        {
            await Repository.DeleteManyAsync(ids);
            await UnitOfWorkManager.Current.SaveChangesAsync();
        }

        [Authorize(remprojectPermissions.Attribute.Default)]

        public async Task<List<ProductAttributeInListDto>> GetListAllAsync()
        {
            var query = await Repository.GetQueryableAsync();
            query = query.Where(x => x.IsActive == true);
            var data = await AsyncExecuter.ToListAsync(query);

            return ObjectMapper.Map<List<ProductAttribute>, List<ProductAttributeInListDto>>(data);

        }

        [Authorize(remprojectPermissions.Attribute.Default)]

        public async Task<PagedResultDto<ProductAttributeInListDto>> GetListFilterAsync(BaseListFilterDto input)
        {
            var query = await Repository.GetQueryableAsync();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Label.Contains(input.Keyword));

            var totalCount = await AsyncExecuter.LongCountAsync(query);
            var data = await AsyncExecuter.ToListAsync(query.Skip(input.SkipCount).Take(input.MaxResultCount));

            return new PagedResultDto<ProductAttributeInListDto>(totalCount, ObjectMapper.Map<List<ProductAttribute>, List<ProductAttributeInListDto>>(data));
        }
    }
}
