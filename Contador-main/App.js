import { StatusBar } from 'expo-status-bar';
import React, { useState } from 'react';
import { StyleSheet, Text, View, Button } from 'react-native';

export default function App() {
  const [playerCount, setPlayerCount] = useState(2);
  const [life, setLife] = useState(20);

  const handlePlayerCountChange = (count) => {
    setPlayerCount(count);
  };

  const handleLifeChange = (value) => {
    setLife(value);
  };

  return (
    <View style={styles.container}>
      <Text>Player Count: {playerCount}</Text>
      <Button title="2 Players" onPress={() => handlePlayerCountChange(2)} />
      <Button title="3 Players" onPress={() => handlePlayerCountChange(3)} />
      <Button title="4 Players" onPress={() => handlePlayerCountChange(4)} />

      <Text>Starting Life: {life}</Text>
      <Button title="20 Life" onPress={() => handleLifeChange(20)} />
      <Button title="40 Life" onPress={() => handleLifeChange(40)} />
      <Button title="60 Life" onPress={() => handleLifeChange(60)} />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
