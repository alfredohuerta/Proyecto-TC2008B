from situación_problema_movilidad import all_road_json

from flask import Flask

app = Flask(__name__)


@app.route('/data')
def get_car_data():
    data = all_road_json
    return data


if __name__ == "__main__":
    app.run(debug=True)
