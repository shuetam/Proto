// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: IC_ANNData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HFAN.Module.Static {

  /// <summary>Holder for reflection information generated from IC_ANNData.proto</summary>
  public static partial class ICANNDataReflection {

    #region Descriptor
    /// <summary>File descriptor for IC_ANNData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ICANNDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBJQ19BTk5EYXRhLnByb3RvEghpY01vZHVsZSIkChFJQ19Bbm5OZXVyb25Q",
            "cm90bxIPCgdXZWlnaHRzGAEgAygBIn0KEElDX0FubkxheWVyUHJvdG8SGgoS",
            "QWN0aXZhdGlvbkZ1bmN0aW9uGAEgASgJEg8KB0Ryb3BPdXQYAiABKAESLAoH",
            "TmV1cm9ucxgDIAMoCzIbLmljTW9kdWxlLklDX0Fubk5ldXJvblByb3RvEg4K",
            "BkJpYXNlcxgEIAMoASKfAgoPSUNfQW5uRGF0YVByb3RvEg4KBkVuZ2luZRgB",
            "IAEoCRIVCg1Ob3JtYWxpemF0aW9uGAIgASgJEg4KBk5JbnB1dBgDIAEoBRIP",
            "CgdOT3V0cHV0GAQgASgFEhQKDExlYXJuaW5nUmF0ZRgFIAEoARIRCglCYXRj",
            "aFNpemUYBiABKAUSEQoJRXBvY2hTaXplGAcgASgFEhEKCU9wdGltaXplchgI",
            "IAEoCRIQCghMb3NzRnVuYxgJIAEoCRIMCgRNYXhWGAogAygBEgwKBE1pblYY",
            "CyADKAESDQoFTWVhblYYDCADKAESDAoEU3RkVhgNIAMoARIqCgZMYXllcnMY",
            "DiADKAsyGi5pY01vZHVsZS5JQ19Bbm5MYXllclByb3RvQhj4AQGqAhJIRkFO",
            "Lk1vZHVsZS5TdGF0aWNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HFAN.Module.Static.IC_AnnNeuronProto), global::HFAN.Module.Static.IC_AnnNeuronProto.Parser, new[]{ "Weights" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HFAN.Module.Static.IC_AnnLayerProto), global::HFAN.Module.Static.IC_AnnLayerProto.Parser, new[]{ "ActivationFunction", "DropOut", "Neurons", "Biases" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HFAN.Module.Static.IC_AnnDataProto), global::HFAN.Module.Static.IC_AnnDataProto.Parser, new[]{ "Engine", "Normalization", "NInput", "NOutput", "LearningRate", "BatchSize", "EpochSize", "Optimizer", "LossFunc", "MaxV", "MinV", "MeanV", "StdV", "Layers" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IC_AnnNeuronProto : pb::IMessage<IC_AnnNeuronProto> {
    private static readonly pb::MessageParser<IC_AnnNeuronProto> _parser = new pb::MessageParser<IC_AnnNeuronProto>(() => new IC_AnnNeuronProto());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IC_AnnNeuronProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HFAN.Module.Static.ICANNDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IC_AnnNeuronProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IC_AnnNeuronProto(IC_AnnNeuronProto other) : this() {
      weights_ = other.weights_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IC_AnnNeuronProto Clone() {
      return new IC_AnnNeuronProto(this);
    }

    /// <summary>Field number for the "Weights" field.</summary>
    public const int WeightsFieldNumber = 1;
    private static readonly pb::FieldCodec<double> _repeated_weights_codec
        = pb::FieldCodec.ForDouble(10);
    private readonly pbc::RepeatedField<double> weights_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> Weights {
      get { return weights_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IC_AnnNeuronProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IC_AnnNeuronProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!weights_.Equals(other.weights_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= weights_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      weights_.WriteTo(output, _repeated_weights_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += weights_.CalculateSize(_repeated_weights_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IC_AnnNeuronProto other) {
      if (other == null) {
        return;
      }
      weights_.Add(other.weights_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 9: {
            weights_.AddEntriesFrom(input, _repeated_weights_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class IC_AnnLayerProto : pb::IMessage<IC_AnnLayerProto> {
    private static readonly pb::MessageParser<IC_AnnLayerProto> _parser = new pb::MessageParser<IC_AnnLayerProto>(() => new IC_AnnLayerProto());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IC_AnnLayerProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HFAN.Module.Static.ICANNDataReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IC_AnnLayerProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IC_AnnLayerProto(IC_AnnLayerProto other) : this() {
      activationFunction_ = other.activationFunction_;
      dropOut_ = other.dropOut_;
      neurons_ = other.neurons_.Clone();
      biases_ = other.biases_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IC_AnnLayerProto Clone() {
      return new IC_AnnLayerProto(this);
    }

    /// <summary>Field number for the "ActivationFunction" field.</summary>
    public const int ActivationFunctionFieldNumber = 1;
    private string activationFunction_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ActivationFunction {
      get { return activationFunction_; }
      set {
        activationFunction_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DropOut" field.</summary>
    public const int DropOutFieldNumber = 2;
    private double dropOut_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double DropOut {
      get { return dropOut_; }
      set {
        dropOut_ = value;
      }
    }

    /// <summary>Field number for the "Neurons" field.</summary>
    public const int NeuronsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::HFAN.Module.Static.IC_AnnNeuronProto> _repeated_neurons_codec
        = pb::FieldCodec.ForMessage(26, global::HFAN.Module.Static.IC_AnnNeuronProto.Parser);
    private readonly pbc::RepeatedField<global::HFAN.Module.Static.IC_AnnNeuronProto> neurons_ = new pbc::RepeatedField<global::HFAN.Module.Static.IC_AnnNeuronProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HFAN.Module.Static.IC_AnnNeuronProto> Neurons {
      get { return neurons_; }
    }

    /// <summary>Field number for the "Biases" field.</summary>
    public const int BiasesFieldNumber = 4;
    private static readonly pb::FieldCodec<double> _repeated_biases_codec
        = pb::FieldCodec.ForDouble(34);
    private readonly pbc::RepeatedField<double> biases_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> Biases {
      get { return biases_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IC_AnnLayerProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IC_AnnLayerProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActivationFunction != other.ActivationFunction) return false;
      if (DropOut != other.DropOut) return false;
      if(!neurons_.Equals(other.neurons_)) return false;
      if(!biases_.Equals(other.biases_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ActivationFunction.Length != 0) hash ^= ActivationFunction.GetHashCode();
      if (DropOut != 0D) hash ^= DropOut.GetHashCode();
      hash ^= neurons_.GetHashCode();
      hash ^= biases_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ActivationFunction.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ActivationFunction);
      }
      if (DropOut != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(DropOut);
      }
      neurons_.WriteTo(output, _repeated_neurons_codec);
      biases_.WriteTo(output, _repeated_biases_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ActivationFunction.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ActivationFunction);
      }
      if (DropOut != 0D) {
        size += 1 + 8;
      }
      size += neurons_.CalculateSize(_repeated_neurons_codec);
      size += biases_.CalculateSize(_repeated_biases_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IC_AnnLayerProto other) {
      if (other == null) {
        return;
      }
      if (other.ActivationFunction.Length != 0) {
        ActivationFunction = other.ActivationFunction;
      }
      if (other.DropOut != 0D) {
        DropOut = other.DropOut;
      }
      neurons_.Add(other.neurons_);
      biases_.Add(other.biases_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            ActivationFunction = input.ReadString();
            break;
          }
          case 17: {
            DropOut = input.ReadDouble();
            break;
          }
          case 26: {
            neurons_.AddEntriesFrom(input, _repeated_neurons_codec);
            break;
          }
          case 34:
          case 33: {
            biases_.AddEntriesFrom(input, _repeated_biases_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class IC_AnnDataProto : pb::IMessage<IC_AnnDataProto> {
    private static readonly pb::MessageParser<IC_AnnDataProto> _parser = new pb::MessageParser<IC_AnnDataProto>(() => new IC_AnnDataProto());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IC_AnnDataProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HFAN.Module.Static.ICANNDataReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IC_AnnDataProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IC_AnnDataProto(IC_AnnDataProto other) : this() {
      engine_ = other.engine_;
      normalization_ = other.normalization_;
      nInput_ = other.nInput_;
      nOutput_ = other.nOutput_;
      learningRate_ = other.learningRate_;
      batchSize_ = other.batchSize_;
      epochSize_ = other.epochSize_;
      optimizer_ = other.optimizer_;
      lossFunc_ = other.lossFunc_;
      maxV_ = other.maxV_.Clone();
      minV_ = other.minV_.Clone();
      meanV_ = other.meanV_.Clone();
      stdV_ = other.stdV_.Clone();
      layers_ = other.layers_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IC_AnnDataProto Clone() {
      return new IC_AnnDataProto(this);
    }

    /// <summary>Field number for the "Engine" field.</summary>
    public const int EngineFieldNumber = 1;
    private string engine_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Engine {
      get { return engine_; }
      set {
        engine_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Normalization" field.</summary>
    public const int NormalizationFieldNumber = 2;
    private string normalization_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Normalization {
      get { return normalization_; }
      set {
        normalization_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "NInput" field.</summary>
    public const int NInputFieldNumber = 3;
    private int nInput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NInput {
      get { return nInput_; }
      set {
        nInput_ = value;
      }
    }

    /// <summary>Field number for the "NOutput" field.</summary>
    public const int NOutputFieldNumber = 4;
    private int nOutput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NOutput {
      get { return nOutput_; }
      set {
        nOutput_ = value;
      }
    }

    /// <summary>Field number for the "LearningRate" field.</summary>
    public const int LearningRateFieldNumber = 5;
    private double learningRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LearningRate {
      get { return learningRate_; }
      set {
        learningRate_ = value;
      }
    }

    /// <summary>Field number for the "BatchSize" field.</summary>
    public const int BatchSizeFieldNumber = 6;
    private int batchSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BatchSize {
      get { return batchSize_; }
      set {
        batchSize_ = value;
      }
    }

    /// <summary>Field number for the "EpochSize" field.</summary>
    public const int EpochSizeFieldNumber = 7;
    private int epochSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EpochSize {
      get { return epochSize_; }
      set {
        epochSize_ = value;
      }
    }

    /// <summary>Field number for the "Optimizer" field.</summary>
    public const int OptimizerFieldNumber = 8;
    private string optimizer_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Optimizer {
      get { return optimizer_; }
      set {
        optimizer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LossFunc" field.</summary>
    public const int LossFuncFieldNumber = 9;
    private string lossFunc_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LossFunc {
      get { return lossFunc_; }
      set {
        lossFunc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MaxV" field.</summary>
    public const int MaxVFieldNumber = 10;
    private static readonly pb::FieldCodec<double> _repeated_maxV_codec
        = pb::FieldCodec.ForDouble(82);
    private readonly pbc::RepeatedField<double> maxV_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> MaxV {
      get { return maxV_; }
    }

    /// <summary>Field number for the "MinV" field.</summary>
    public const int MinVFieldNumber = 11;
    private static readonly pb::FieldCodec<double> _repeated_minV_codec
        = pb::FieldCodec.ForDouble(90);
    private readonly pbc::RepeatedField<double> minV_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> MinV {
      get { return minV_; }
    }

    /// <summary>Field number for the "MeanV" field.</summary>
    public const int MeanVFieldNumber = 12;
    private static readonly pb::FieldCodec<double> _repeated_meanV_codec
        = pb::FieldCodec.ForDouble(98);
    private readonly pbc::RepeatedField<double> meanV_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> MeanV {
      get { return meanV_; }
    }

    /// <summary>Field number for the "StdV" field.</summary>
    public const int StdVFieldNumber = 13;
    private static readonly pb::FieldCodec<double> _repeated_stdV_codec
        = pb::FieldCodec.ForDouble(106);
    private readonly pbc::RepeatedField<double> stdV_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> StdV {
      get { return stdV_; }
    }

    /// <summary>Field number for the "Layers" field.</summary>
    public const int LayersFieldNumber = 14;
    private static readonly pb::FieldCodec<global::HFAN.Module.Static.IC_AnnLayerProto> _repeated_layers_codec
        = pb::FieldCodec.ForMessage(114, global::HFAN.Module.Static.IC_AnnLayerProto.Parser);
    private readonly pbc::RepeatedField<global::HFAN.Module.Static.IC_AnnLayerProto> layers_ = new pbc::RepeatedField<global::HFAN.Module.Static.IC_AnnLayerProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HFAN.Module.Static.IC_AnnLayerProto> Layers {
      get { return layers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IC_AnnDataProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IC_AnnDataProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Engine != other.Engine) return false;
      if (Normalization != other.Normalization) return false;
      if (NInput != other.NInput) return false;
      if (NOutput != other.NOutput) return false;
      if (LearningRate != other.LearningRate) return false;
      if (BatchSize != other.BatchSize) return false;
      if (EpochSize != other.EpochSize) return false;
      if (Optimizer != other.Optimizer) return false;
      if (LossFunc != other.LossFunc) return false;
      if(!maxV_.Equals(other.maxV_)) return false;
      if(!minV_.Equals(other.minV_)) return false;
      if(!meanV_.Equals(other.meanV_)) return false;
      if(!stdV_.Equals(other.stdV_)) return false;
      if(!layers_.Equals(other.layers_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Engine.Length != 0) hash ^= Engine.GetHashCode();
      if (Normalization.Length != 0) hash ^= Normalization.GetHashCode();
      if (NInput != 0) hash ^= NInput.GetHashCode();
      if (NOutput != 0) hash ^= NOutput.GetHashCode();
      if (LearningRate != 0D) hash ^= LearningRate.GetHashCode();
      if (BatchSize != 0) hash ^= BatchSize.GetHashCode();
      if (EpochSize != 0) hash ^= EpochSize.GetHashCode();
      if (Optimizer.Length != 0) hash ^= Optimizer.GetHashCode();
      if (LossFunc.Length != 0) hash ^= LossFunc.GetHashCode();
      hash ^= maxV_.GetHashCode();
      hash ^= minV_.GetHashCode();
      hash ^= meanV_.GetHashCode();
      hash ^= stdV_.GetHashCode();
      hash ^= layers_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Engine.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Engine);
      }
      if (Normalization.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Normalization);
      }
      if (NInput != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NInput);
      }
      if (NOutput != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(NOutput);
      }
      if (LearningRate != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(LearningRate);
      }
      if (BatchSize != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(BatchSize);
      }
      if (EpochSize != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(EpochSize);
      }
      if (Optimizer.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Optimizer);
      }
      if (LossFunc.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(LossFunc);
      }
      maxV_.WriteTo(output, _repeated_maxV_codec);
      minV_.WriteTo(output, _repeated_minV_codec);
      meanV_.WriteTo(output, _repeated_meanV_codec);
      stdV_.WriteTo(output, _repeated_stdV_codec);
      layers_.WriteTo(output, _repeated_layers_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Engine.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Engine);
      }
      if (Normalization.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Normalization);
      }
      if (NInput != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NInput);
      }
      if (NOutput != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NOutput);
      }
      if (LearningRate != 0D) {
        size += 1 + 8;
      }
      if (BatchSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BatchSize);
      }
      if (EpochSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EpochSize);
      }
      if (Optimizer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Optimizer);
      }
      if (LossFunc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LossFunc);
      }
      size += maxV_.CalculateSize(_repeated_maxV_codec);
      size += minV_.CalculateSize(_repeated_minV_codec);
      size += meanV_.CalculateSize(_repeated_meanV_codec);
      size += stdV_.CalculateSize(_repeated_stdV_codec);
      size += layers_.CalculateSize(_repeated_layers_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IC_AnnDataProto other) {
      if (other == null) {
        return;
      }
      if (other.Engine.Length != 0) {
        Engine = other.Engine;
      }
      if (other.Normalization.Length != 0) {
        Normalization = other.Normalization;
      }
      if (other.NInput != 0) {
        NInput = other.NInput;
      }
      if (other.NOutput != 0) {
        NOutput = other.NOutput;
      }
      if (other.LearningRate != 0D) {
        LearningRate = other.LearningRate;
      }
      if (other.BatchSize != 0) {
        BatchSize = other.BatchSize;
      }
      if (other.EpochSize != 0) {
        EpochSize = other.EpochSize;
      }
      if (other.Optimizer.Length != 0) {
        Optimizer = other.Optimizer;
      }
      if (other.LossFunc.Length != 0) {
        LossFunc = other.LossFunc;
      }
      maxV_.Add(other.maxV_);
      minV_.Add(other.minV_);
      meanV_.Add(other.meanV_);
      stdV_.Add(other.stdV_);
      layers_.Add(other.layers_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Engine = input.ReadString();
            break;
          }
          case 18: {
            Normalization = input.ReadString();
            break;
          }
          case 24: {
            NInput = input.ReadInt32();
            break;
          }
          case 32: {
            NOutput = input.ReadInt32();
            break;
          }
          case 41: {
            LearningRate = input.ReadDouble();
            break;
          }
          case 48: {
            BatchSize = input.ReadInt32();
            break;
          }
          case 56: {
            EpochSize = input.ReadInt32();
            break;
          }
          case 66: {
            Optimizer = input.ReadString();
            break;
          }
          case 74: {
            LossFunc = input.ReadString();
            break;
          }
          case 82:
          case 81: {
            maxV_.AddEntriesFrom(input, _repeated_maxV_codec);
            break;
          }
          case 90:
          case 89: {
            minV_.AddEntriesFrom(input, _repeated_minV_codec);
            break;
          }
          case 98:
          case 97: {
            meanV_.AddEntriesFrom(input, _repeated_meanV_codec);
            break;
          }
          case 106:
          case 105: {
            stdV_.AddEntriesFrom(input, _repeated_stdV_codec);
            break;
          }
          case 114: {
            layers_.AddEntriesFrom(input, _repeated_layers_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
