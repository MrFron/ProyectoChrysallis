package com.example.eventos.API.APIServices;

import com.example.eventos.Assistir;
import com.example.eventos.Soci;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;

public interface SociService {

    @GET("api/Socis/getSoci/{telefon}")
    Call<Soci> getValidacio(@Path( "telefon" ) String telefon );

}
