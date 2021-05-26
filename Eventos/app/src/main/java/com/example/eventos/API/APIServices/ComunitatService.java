package com.example.eventos.API.APIServices;

import com.example.eventos.Comunitat;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.POST;

public interface ComunitatService {

    @POST("api/comunitats/esdeveniments/")
    Call<List<Comunitat>> getComunitatEsdeveniments(@Body List<Integer> idComunitats);

}
