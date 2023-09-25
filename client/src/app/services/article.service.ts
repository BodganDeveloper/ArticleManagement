import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Article } from '../shared/types/article';
import { config } from '../shared/config';

const url = `${config.apiUrl}/article`;

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  constructor(private readonly http: HttpClient) { }

  getAll(): Observable<Article[]> {
    return this.http
      .get<Article[]>(`${url}`);
  }

  getById(id: string): Observable<Article> {
    return this.http
      .get<Article>(`${url}/${id}`);
  }

  create(article: Article): Observable<Article> {
    return this.http
      .post<Article>(`${url}`, article);
  }

  update(id: string, title: string, content: string): Observable<Article> {
    return this.http
      .put<Article>(`${url}/${id}`, {title, content});
  }

  delete(id: string): Observable<Article> {
    return this.http
      .delete<Article>(`${url}/${id}`);
  }
}
