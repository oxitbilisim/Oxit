import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { appSettings } from './appsettings';
import { environment } from './environments/environment';

if (environment.production) {
  enableProdMode();

}

platformBrowserDynamic().bootstrapModule(AppModule, {
  useJit: true,
  preserveWhitespaces: true
})
  .catch(err => console.log(err));
