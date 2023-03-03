import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'residential_web',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44353/',
    redirectUri: baseUrl,
    clientId: 'residential_web_App',
    responseType: 'code',
    scope: 'offline_access residential_web',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44399',
      rootNamespace: 'abb.residential_web',
    },
  },
} as Environment;
