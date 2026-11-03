import QtQuick
import QtQuick.Controls
import QtQuick.Layouts

ApplicationWindow {
    id: win
    visible: true
    title: "Qt Bridge for C#"
    width: 640; height: 480

    Exposer {
        id: exposer
    }

    ColumnLayout {
        Label {
            text: "Direct access to observable"
        }

        Label {
            text: exposer.observable.myInt.toString()
        }

        Label {
            text: "Access to observable via interface"
        }

        Label {
            text: exposer.observableViaInterface.myInt.toString()
        }
    }
}
