package pl.bbl.game.entities;

import com.badlogic.gdx.graphics.g3d.ModelInstance;
import com.badlogic.gdx.math.Vector3;

public abstract class GameObject {
    private ModelInstance modelInstance;

    protected GameObject(){
    }

    public void update(){

    }

    public void render(){

    }

    public Vector3 getPosition(){
        if(isModelLoaded())
            return modelInstance.transform.getTranslation(new Vector3());
        return null;
    }

    public void setPosition(Vector3 vector3){
        if(isModelLoaded())
            modelInstance.transform.setToTranslation(vector3);
    }

    public boolean isModelLoaded(){
        return modelInstance != null;
    }

}
