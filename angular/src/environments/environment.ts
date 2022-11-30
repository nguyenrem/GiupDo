import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'remproject',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44352/',
    redirectUri: baseUrl,
    clientId: 'remproject_App',
    responseType: 'code',
    scope: 'offline_access remproject',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44356',
      rootNamespace: 'remproject',
    },
  },
} as Environment;
