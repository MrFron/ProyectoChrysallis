package com.example.eventos.API.APIServices;

import com.example.eventos.Assistir;
import com.example.eventos.Event;

import java.util.List;

import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.PUT;
import retrofit2.http.Path;

public interface AssistirService {

    @GET("api/esdeveniments/esdAsistir/{numSoci}")
    Call<List<Assistir>> getMisEventos(@Path( "numSoci" ) int numSoci );

    @POST("api/assistirs")
    Call<Assistir> postAssistir(@Body Assistir assistirs);

    @PUT("api/assistirs/{id}")
    Call<ResponseBody> updateAssistir(@Path("id") int id, @Body Assistir assistir);

}
