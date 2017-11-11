package pl.bbl.game.entities.exceptions.models;

public class ModelNotLoadedException extends Exception{
    public ModelNotLoadedException(){
        super("Model wasn't loaded.");
    }
}
