# Covid - 19 Vaccine Sentiment Analysis
## Pandata 

Se utilizan 4 datasets:
<ul>
<li>uscities.csv -Dataset con geolocalización de las ciudades
<li>tweets_api.csv -Dataset generado del API utyilizado en el dashboard
<li>tweets_positive.csv -Dataset generado del API con categoría positiva
<li>tweets_negative.csv -Dataset generado del API con categoría negativa
<li>vaccination_tweets.csv -Dataset proporcionado por el equipo de Datacup
<li> data_with_sa.csv - Dataset ya clasificado
</ul>

Se utilizan las siguientes librerias:
<ul>
<li>Pandas - para traer los datos
<li>Numpy - para transformación de datos
<li>Re - para transformación de datos
<li>Nltk - para el modelo VADER
<li>Tweepy - para conectarse al API
<li>Tensorflow - para la red neuronal
<li>Keras - para la red neuronal
<li>Sci-kit learn -Train/test split
</ul>

Pasos para realizar el análisis de sentimientos:
<ol>
<li>Verificar que la dirección de los archivos .csv utilizados para que concuerden con los notebooks
<li>Extraer los datos de la API utilizando el notebook twitter_api.ipynb. Se requiere ejecutar dos veces, agregando en la variable search words agregando :) o :( en el query de busqueda para traer los tweets positivos y negativos respectivamente.
<li> Se hace el Análisis exploratorio ejecutando el notebook EDA.ipynb
<li> Una vez que se obtienen los datos del API, se utiliza el notebook de SA_Red_86.ipynb para entrenar la red neuronal y hacer la clasificación de los tweets.
</ol>

### Notas:
<ul>
<li>Debido a que para conectarse a la API de twitter se debe tener cuenta de desarrollador, no podrá ser posible extraer más datos, por lo que se proporcionan los csv de ejemplo (tweets_positive, tweets_negative)
<li>El dashboard y las herramientas utilizadas de Azure, a no ser código no se adjuntan en el repositorio.
</ul>
