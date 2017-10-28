package pl.bbl.game;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Game;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;
import pl.bbl.game.screens.GameScreen;

public class BlocksGame extends Game {
    @Override
	public void create () {
		this.setScreen(new GameScreen(this));
	}
}
