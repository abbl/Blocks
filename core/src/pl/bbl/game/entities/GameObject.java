package pl.bbl.game.entities;

import com.badlogic.gdx.math.Vector3;

public abstract class GameObject {
    private Vector3 position;

    protected GameObject(){
        position = new Vector3();
    }

    public void update(){

    }

    public void render(){

    }

    public Vector3 getPosition(){
        return position;
    }

    public void setPosition(Vector3 position){
        this.position = position;
    }
}
