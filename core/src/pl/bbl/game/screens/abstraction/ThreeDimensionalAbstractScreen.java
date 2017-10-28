package pl.bbl.game.screens.abstraction;

import com.badlogic.gdx.Game;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.Screen;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.PerspectiveCamera;
import com.badlogic.gdx.graphics.g3d.Environment;
import com.badlogic.gdx.graphics.g3d.ModelBatch;

public abstract class ThreeDimensionalAbstractScreen implements Screen {
    protected PerspectiveCamera camera;
    protected ModelBatch modelBatch;
    protected Environment environment;
    protected Game game;

    protected ThreeDimensionalAbstractScreen(final Game game){
        this.game = game;
        initializeCamera();
        initializeBatch();
        initializeEnvironment();
    }

    private void initializeCamera(){
        camera = new PerspectiveCamera(67, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());
        camera.position.set(0f, 10f, 10f);
        camera.lookAt(0,0,0);
        camera.near = 1f;
        camera.far = 300f;
    }

    private void initializeBatch(){
        modelBatch = new ModelBatch();
    }

    private void initializeEnvironment(){
        environment = new Environment();
    }

    @Override
    public void render(float delta) {
        Gdx.gl.glViewport(0, 0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());
        Gdx.gl.glClearColor(135f / 255f, 206 / 255f, 255 / 255f, 1);
        Gdx.gl.glClear(GL20.GL_COLOR_BUFFER_BIT | GL20.GL_DEPTH_BUFFER_BIT);

        update();
        camera.update();
        modelBatch.begin(camera);
        renderModels();
        modelBatch.end();
    }

    abstract protected void renderModels();

    abstract protected void update();

    @Override
    public void show() {}

    @Override
    public void resize(int width, int height) {}

    @Override
    public void pause() {}

    @Override
    public void resume() {}

    @Override
    public void hide() {}

    @Override
    public void dispose() {
        modelBatch.dispose();
    }
}
