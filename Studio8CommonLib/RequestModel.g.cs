﻿// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RequestModel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from RequestModel.proto</summary>
public static partial class RequestModelReflection
{

    #region Descriptor
    /// <summary>File descriptor for RequestModel.proto</summary>
    public static pbr::FileDescriptor Descriptor
    {
        get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestModelReflection()
    {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "ChJSZXF1ZXN0TW9kZWwucHJvdG8iLAoLQ2FsY1JlcXVlc3QSDwoHbmF0dXJh",
              "bBgBIAEoBRIMCgR3b3JkGAIgASgJIi0KCkNhbGNSZXN1bHQSDgoGcmVzdWx0",
              "GAIgASgBEg8KB21lc3NhZ2UYASABKAkyMAoLQ2FsY1NlcnZpY2USIQoEQ2Fs",
              "YxIMLkNhbGNSZXF1ZXN0GgsuQ2FsY1Jlc3VsdGIGcHJvdG8z"));
        descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
            new pbr::FileDescriptor[] { },
            new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CalcRequest), global::CalcRequest.Parser, new[]{ "Natural", "Word" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::CalcResult), global::CalcResult.Parser, new[]{ "Result", "Message" }, null, null, null)
            }));
    }
    #endregion

}
#region Messages
public sealed partial class CalcRequest : pb::IMessage<CalcRequest>, IValidatableObject
{
    public scg.IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        List<ValidationResult> errors = new List<ValidationResult>();

        if ((Word == "cube" && Natural % 2 != 0) || (Word == "square" && Natural % 2 == 0))
        {
            errors.Add(new ValidationResult("Все числа которые идут в паре с square должны быть нечетными, а с cube четными"));
        }

        return errors;
    }

    public bool DoValidate(List<ValidationResult> results)
    {
        var context = new ValidationContext(this);
        if (!Validator.TryValidateObject(this, context, results, true))
        {
            return false;
        }
        return true;
    }

    private static readonly pb::MessageParser<CalcRequest> _parser = new pb::MessageParser<CalcRequest>(() => new CalcRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CalcRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::RequestModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalcRequest()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalcRequest(CalcRequest other) : this()
    {
        natural_ = other.natural_;
        word_ = other.word_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalcRequest Clone()
    {
        return new CalcRequest(this);
    }

    /// <summary>Field number for the "natural" field.</summary>
    public const int NaturalFieldNumber = 1;
    private int natural_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [Required(ErrorMessage = "Не указано натуральное число")]
    [Range(1, 100, ErrorMessage = "Число должно быть в диапазоне от 1 до 100")]
    public int Natural
    {
        get { return natural_; }
        set
        {
            natural_ = value;
        }
    }

    /// <summary>Field number for the "word" field.</summary>
    public const int WordFieldNumber = 2;
    private string word_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [Required(ErrorMessage = "Не указан параметр - слово")]
    [RegularExpression(@"^(cube|square)$", ErrorMessage = "Слово должно быть cube или square")]
    public string Word
    {
        get { return word_; }
        set
        {
            word_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other)
    {
        return Equals(other as CalcRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CalcRequest other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (Natural != other.Natural) return false;
        if (Word != other.Word) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode()
    {
        int hash = 1;
        if (Natural != 0) hash ^= Natural.GetHashCode();
        if (Word.Length != 0) hash ^= Word.GetHashCode();
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output)
    {
        if (Natural != 0)
        {
            output.WriteRawTag(8);
            output.WriteInt32(Natural);
        }
        if (Word.Length != 0)
        {
            output.WriteRawTag(18);
            output.WriteString(Word);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(output);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize()
    {
        int size = 0;
        if (Natural != 0)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Natural);
        }
        if (Word.Length != 0)
        {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Word);
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CalcRequest other)
    {
        if (other == null)
        {
            return;
        }
        if (other.Natural != 0)
        {
            Natural = other.Natural;
        }
        if (other.Word.Length != 0)
        {
            Word = other.Word;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                    break;
                case 8:
                    {
                        Natural = input.ReadInt32();
                        break;
                    }
                case 18:
                    {
                        Word = input.ReadString();
                        break;
                    }
            }
        }
    }

}

public sealed partial class CalcResult : pb::IMessage<CalcResult>
{
    private static readonly pb::MessageParser<CalcResult> _parser = new pb::MessageParser<CalcResult>(() => new CalcResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CalcResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::RequestModelReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalcResult()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalcResult(CalcResult other) : this()
    {
        result_ = other.result_;
        message_ = other.message_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalcResult Clone()
    {
        return new CalcResult(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 2;
    private double result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Result
    {
        get { return result_; }
        set
        {
            result_ = value;
        }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message
    {
        get { return message_; }
        set
        {
            message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other)
    {
        return Equals(other as CalcResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CalcResult other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Result, other.Result)) return false;
        if (Message != other.Message) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode()
    {
        int hash = 1;
        if (Result != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Result);
        if (Message.Length != 0) hash ^= Message.GetHashCode();
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output)
    {
        if (Message.Length != 0)
        {
            output.WriteRawTag(10);
            output.WriteString(Message);
        }
        if (Result != 0D)
        {
            output.WriteRawTag(17);
            output.WriteDouble(Result);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(output);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize()
    {
        int size = 0;
        if (Result != 0D)
        {
            size += 1 + 8;
        }
        if (Message.Length != 0)
        {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CalcResult other)
    {
        if (other == null)
        {
            return;
        }
        if (other.Result != 0D)
        {
            Result = other.Result;
        }
        if (other.Message.Length != 0)
        {
            Message = other.Message;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                    break;
                case 10:
                    {
                        Message = input.ReadString();
                        break;
                    }
                case 17:
                    {
                        Result = input.ReadDouble();
                        break;
                    }
            }
        }
    }

}

#endregion


#endregion Designer generated code