package com.example.eventos;

import java.util.ArrayList;

public class Comunitat {

    private ArrayList<Event> esdeveniments;
    private int id;
    private String nom;


    public Comunitat(ArrayList<Event> esdeveniments, int id, String nom) {
        this.esdeveniments = esdeveniments;
        this.id = id;
        this.nom = nom;
    }

    public ArrayList<Event> getEsdeveniment() {
        return esdeveniments;
    }

    public void setEsdeveniment(ArrayList<Event> esdeveniments) {
        this.esdeveniments = esdeveniments;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }
}

