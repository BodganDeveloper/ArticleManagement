import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ArticleCreateComponent } from './components/article-create/article-create.component';
import { ArticleUpdateComponent } from './components/article-update/article-update.component';
import { ArticleListComponent } from './components/article-list/article-list.component';
import { ArticleItemComponent } from './components/article-item/article-item.component';

@NgModule({
  declarations: [
    AppComponent,
    ArticleCreateComponent,
    ArticleUpdateComponent,
    ArticleListComponent,
    ArticleItemComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
