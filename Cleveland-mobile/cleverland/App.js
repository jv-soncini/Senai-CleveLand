import React, { Fragment, Component } from 'react';
import {
  SafeAreaView,
  StyleSheet,
  ScrollView,
  View,
  Text,
  StatusBar,
} from 'react-native';

import {
  Header,
  LearnMoreLinks,
  Colors,
  DebugInstructions,
  ReloadInstructions,
} from 'react-native/Libraries/NewAppScreen';


class App extends Component {
  render() {

    return (

      <View>
        <Text style={styles.titulo}>Medicos</Text>

      </View>

    )
  }
}


const styles = StyleSheet.create({
  scrollView: {
    backgroundColor: Colors.lighter,
  },
  titulo: {
    fontSize: 30,
    color: "#80bfff",
    textAlign: "center"
  },
})

export default App;
