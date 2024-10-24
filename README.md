# Golay Code Simulator

## Overview
This project simulates the encoding, transmission, and decoding of data using the **[23,12] Golay code**, a powerful error-correcting code. The simulator showcases how data is encoded, transmitted through a noisy channel with specified error probabilities, and decoded to correct errors. Additionally, it compares the performance of encoded versus unencoded data.

## Features
- **Encoding:** Converts 12-bit binary vectors into 23-bit codewords using Golay code.
- **Noisy Channel Simulation:** Sends encoded data through a noisy channel, applying a customizable error probability.
- **Decoding and Error Correction:** Demonstrates how the Golay code corrects transmission errors.
- **Comparison:** Highlights the improvement in transmission reliability when using Golay encoding versus no encoding.

## How It Works
1. **Input Data:** Start by selecting your input data type.
2. **Encoding:** The input data is encoded using the [23,12] Golay code.
3. **Transmission:** Simulate data transmission through a noisy channel by setting the error probability.
4. **Decoding:** The received codeword is decoded, and errors are corrected based on Golay’s capabilities.
5. **Results:** Compare the effectiveness of Golay code by seeing how the encoded data survives the noisy channel compared to unencoded data.

## Requirements
To run this project:
- **C# Environment:** Visual Studio with support for Windows Forms is required to compile and run the project.
- **.NET Framework:** Ensure the project is set up with the appropriate version of .NET.

## How to Run
1. Clone or download this repository.
2. Open the solution file (`Golay-Code.sln`) in Visual Studio.
3. Build the solution.
4. Run the program to interact with the Golay Code simulation.
