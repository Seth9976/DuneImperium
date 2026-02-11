using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using JsonFx.IO;
using JsonFx.Serialization;

namespace JsonFx.Model
{
	// Token: 0x0200001F RID: 31
	public sealed class ModelAnalyzer : Object
	{
		// Token: 0x0600015F RID: 351 RVA: 0x00008C28 File Offset: 0x00006E28
		// Note: this type is marked as 'beforefieldinit'.
		static ModelAnalyzer()
		{
			Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Model", "ModelAnalyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr);
			ModelAnalyzer.NativeFieldInfoPtr_ErrorUnexpectedToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, "ErrorUnexpectedToken");
			ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, "ErrorExpectedArray");
			ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArrayItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, "ErrorExpectedArrayItem");
			ModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, "ErrorUnterminatedArray");
			ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, "ErrorExpectedObject");
			ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, "ErrorExpectedPropertyName");
			ModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, "ErrorUnterminatedObject");
			ModelAnalyzer.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, "Settings");
			ModelAnalyzer.NativeFieldInfoPtr_Coercion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, "Coercion");
			ModelAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, 100663447);
			ModelAnalyzer.NativeMethodInfoPtr_JsonFx_Serialization_ITokenAnalyzer_get_Settings_Private_Virtual_Final_New_get_DataReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, 100663448);
			ModelAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_Object_IEnumerable_1_Token_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, 100663449);
			ModelAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_TResult_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, 100663450);
			ModelAnalyzer.NativeMethodInfoPtr_ConsumeValue_Private_Object_Stream_1_Token_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, 100663451);
			ModelAnalyzer.NativeMethodInfoPtr_ConsumeObject_Private_Object_Stream_1_Token_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, 100663452);
			ModelAnalyzer.NativeMethodInfoPtr_ConsumeArray_Private_Object_Stream_1_Token_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr, 100663453);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00008D98 File Offset: 0x00006F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191158, XrefRangeEnd = 1191178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModelAnalyzer(DataReaderSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00008DE4 File Offset: 0x00006FE4
		public unsafe DataReaderSettings JsonFx.Serialization.ITokenAnalyzer.Settings
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelAnalyzer.NativeMethodInfoPtr_JsonFx_Serialization_ITokenAnalyzer_get_Settings_Private_Virtual_Final_New_get_DataReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00008E24 File Offset: 0x00007024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191178, XrefRangeEnd = 1191188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Analyze(IEnumerable<Token> tokens, Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_Object_IEnumerable_1_Token_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00008E88 File Offset: 0x00007088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191188, XrefRangeEnd = 1191213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult Analyze<TResult>(IEnumerable<Token> tokens)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelAnalyzer.MethodInfoStoreGeneric_Analyze_Public_Virtual_Final_New_TResult_IEnumerable_1_Token_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00008ED4 File Offset: 0x000070D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1191214, RefRangeEnd = 1191217, XrefRangeStart = 1191213, XrefRangeEnd = 1191214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConsumeValue(Stream<Token> tokens, Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelAnalyzer.NativeMethodInfoPtr_ConsumeValue_Private_Object_Stream_1_Token_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00008F38 File Offset: 0x00007138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1191237, RefRangeEnd = 1191239, XrefRangeStart = 1191217, XrefRangeEnd = 1191237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConsumeObject(Stream<Token> tokens, Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelAnalyzer.NativeMethodInfoPtr_ConsumeObject_Private_Object_Stream_1_Token_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00008F9C File Offset: 0x0000719C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1191266, RefRangeEnd = 1191267, XrefRangeStart = 1191239, XrefRangeEnd = 1191266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConsumeArray(Stream<Token> tokens, Type arrayType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelAnalyzer.NativeMethodInfoPtr_ConsumeArray_Private_Object_Stream_1_Token_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000028FA File Offset: 0x00000AFA
		public ModelAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00009000 File Offset: 0x00007200
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002903 File Offset: 0x00000B03
		public unsafe static string ErrorUnexpectedToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorUnexpectedToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorUnexpectedToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00009020 File Offset: 0x00007220
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002915 File Offset: 0x00000B15
		public unsafe static string ErrorExpectedArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArray, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArray, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00009040 File Offset: 0x00007240
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002927 File Offset: 0x00000B27
		public unsafe static string ErrorExpectedArrayItem
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArrayItem, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArrayItem, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00009060 File Offset: 0x00007260
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002939 File Offset: 0x00000B39
		public unsafe static string ErrorUnterminatedArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedArray, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedArray, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00009080 File Offset: 0x00007280
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0000294B File Offset: 0x00000B4B
		public unsafe static string ErrorExpectedObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedObject, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedObject, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000090A0 File Offset: 0x000072A0
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0000295D File Offset: 0x00000B5D
		public unsafe static string ErrorExpectedPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000090C0 File Offset: 0x000072C0
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0000296F File Offset: 0x00000B6F
		public unsafe static string ErrorUnterminatedObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedObject, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedObject, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000090E0 File Offset: 0x000072E0
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002981 File Offset: 0x00000B81
		public unsafe DataReaderSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelAnalyzer.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataReaderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelAnalyzer.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00009110 File Offset: 0x00007310
		// (set) Token: 0x06000179 RID: 377 RVA: 0x000029A0 File Offset: 0x00000BA0
		public unsafe TypeCoercionUtility Coercion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelAnalyzer.NativeFieldInfoPtr_Coercion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeCoercionUtility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelAnalyzer.NativeFieldInfoPtr_Coercion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_ErrorUnexpectedToken;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_ErrorExpectedArray;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_ErrorExpectedArrayItem;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_ErrorUnterminatedArray;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_ErrorExpectedObject;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_ErrorExpectedPropertyName;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_ErrorUnterminatedObject;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_Coercion;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_JsonFx_Serialization_ITokenAnalyzer_get_Settings_Private_Virtual_Final_New_get_DataReaderSettings_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_Object_IEnumerable_1_Token_Type_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_TResult_IEnumerable_1_Token_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeValue_Private_Object_Stream_1_Token_Type_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeObject_Private_Object_Stream_1_Token_Type_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeArray_Private_Object_Stream_1_Token_Type_0;

		// Token: 0x0200003F RID: 63
		private sealed class MethodInfoStoreGeneric_Analyze_Public_Virtual_Final_New_TResult_IEnumerable_1_Token_0<TResult>
		{
			// Token: 0x0400021E RID: 542
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ModelAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_TResult_IEnumerable_1_Token_0, Il2CppClassPointerStore<ModelAnalyzer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
