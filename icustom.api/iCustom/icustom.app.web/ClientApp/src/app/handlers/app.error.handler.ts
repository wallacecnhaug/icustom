import { Response } from '@angular/http';
import { Observable } from 'rxjs';

export 
  class ErrorHandler {

  static TratarError(error: Response | any) {
    let msgErro: string;

    msgErro = error.toString();

    if (error instanceof Response) {
      msgErro = `Erro ${error.status} na resposta da requisição ${error.url} - ${error.statusText}`;
    }

    console.log(msgErro);

    return Observable.throw(msgErro);

  }

}
