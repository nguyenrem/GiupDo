import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'remproject Admin',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:5000/',
    redirectUri: baseUrl,
    clientId: 'remproject_Admin',
    dummyClientSecret:'1q2w3e*',
    responseType: 'code',
    scope: 'offline_access remproject.Admin',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:5001',
      rootNamespace: 'remproject.Admin',
    },
  },
} as Environment;
