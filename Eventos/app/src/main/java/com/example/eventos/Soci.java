package com.example.eventos;

public class Soci {

    private int id;
    private String telefon;
    private String mail;
    private String nom;
    private String cognoms;
    private String contrasenya;
    private Boolean actiu;
    private Boolean administrador;


    public Soci(int id, String telefon, String mail, String nom, String cognoms, String contrasenya, Boolean actiu, Boolean administrador) {
        this.id = id;
        this.telefon = telefon;
        this.mail = mail;
        this.nom = nom;
        this.cognoms = cognoms;
        this.contrasenya = contrasenya;
        this.actiu = actiu;
        this.administrador = administrador;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTelefon() {
        return telefon;
    }

    public void setTelefon(String telefon) {
        this.telefon = telefon;
    }

    public String getMail() {
        return mail;
    }

    public void setMail(String mail) {
        this.mail = mail;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getCognoms() {
        return cognoms;
    }

    public void setCognoms(String cognoms) {
        this.cognoms = cognoms;
    }

    public String getContrasenya() {
        return contrasenya;
    }

    public void setContrasenya(String contrasenya) {
        this.contrasenya = contrasenya;
    }

    public Boolean getActiu() {
        return actiu;
    }

    public void setActiu(Boolean actiu) {
        this.actiu = actiu;
    }

    public Boolean getAdministrador() {
        return administrador;
    }

    public void setAdministrador(Boolean administrador) {
        this.administrador = administrador;
    }
}
