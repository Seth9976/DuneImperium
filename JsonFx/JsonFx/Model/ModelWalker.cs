using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using JsonFx.Serialization;
using JsonFx.Serialization.GraphCycles;

namespace JsonFx.Model
{
	// Token: 0x02000023 RID: 35
	public class ModelWalker : Object
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x00009DF8 File Offset: 0x00007FF8
		// Note: this type is marked as 'beforefieldinit'.
		static ModelWalker()
		{
			Il2CppClassPointerStore<ModelWalker>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Model", "ModelWalker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr);
			ModelWalker.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr, "Settings");
			ModelWalker.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr, 100663527);
			ModelWalker.NativeMethodInfoPtr_GetTokens_Public_Virtual_Final_New_IEnumerable_1_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr, 100663528);
			ModelWalker.NativeMethodInfoPtr_GetTokens_Protected_Virtual_New_Void_List_1_Token_ICycleDetector_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr, 100663529);
			ModelWalker.NativeMethodInfoPtr_GetArrayTokens_Protected_Void_List_1_Token_ICycleDetector_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr, 100663530);
			ModelWalker.NativeMethodInfoPtr_GetObjectTokens_Protected_Void_List_1_Token_ICycleDetector_String_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr, 100663531);
			ModelWalker.NativeMethodInfoPtr_GetObjectTokens_Protected_Void_List_1_Token_ICycleDetector_String_IEnumerator_1_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr, 100663532);
			ModelWalker.NativeMethodInfoPtr_GetObjectTokens_Protected_Void_List_1_Token_ICycleDetector_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr, 100663533);
			ModelWalker.NativeMethodInfoPtr_GetTypeName_Private_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr, 100663534);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00009EDC File Offset: 0x000080DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1191797, RefRangeEnd = 1191801, XrefRangeStart = 1191788, XrefRangeEnd = 1191797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModelWalker(DataWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelWalker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelWalker.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00009F28 File Offset: 0x00008128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191801, XrefRangeEnd = 1191821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Token> GetTokens(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelWalker.NativeMethodInfoPtr_GetTokens_Public_Virtual_Final_New_IEnumerable_1_Token_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00009F78 File Offset: 0x00008178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1192006, RefRangeEnd = 1192008, XrefRangeStart = 1191821, XrefRangeEnd = 1192006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetTokens(List<Token> tokens, ICycleDetector detector, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModelWalker.NativeMethodInfoPtr_GetTokens_Protected_Virtual_New_Void_List_1_Token_ICycleDetector_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00009FEC File Offset: 0x000081EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1192020, RefRangeEnd = 1192021, XrefRangeStart = 1192008, XrefRangeEnd = 1192020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetArrayTokens(List<Token> tokens, ICycleDetector detector, IEnumerable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelWalker.NativeMethodInfoPtr_GetArrayTokens_Protected_Void_List_1_Token_ICycleDetector_IEnumerable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000A054 File Offset: 0x00008254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192021, XrefRangeEnd = 1192073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectTokens(List<Token> tokens, ICycleDetector detector, string typeName, IDictionaryEnumerator enumerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelWalker.NativeMethodInfoPtr_GetObjectTokens_Protected_Void_List_1_Token_ICycleDetector_String_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000A0D0 File Offset: 0x000082D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1192107, RefRangeEnd = 1192108, XrefRangeStart = 1192073, XrefRangeEnd = 1192107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectTokens(List<Token> tokens, ICycleDetector detector, string typeName, IEnumerator<KeyValuePair<string, Object>> enumerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelWalker.NativeMethodInfoPtr_GetObjectTokens_Protected_Void_List_1_Token_ICycleDetector_String_IEnumerator_1_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000A14C File Offset: 0x0000834C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1192156, RefRangeEnd = 1192157, XrefRangeStart = 1192108, XrefRangeEnd = 1192156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectTokens(List<Token> tokens, ICycleDetector detector, Type type, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelWalker.NativeMethodInfoPtr_GetObjectTokens_Protected_Void_List_1_Token_ICycleDetector_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000A1C8 File Offset: 0x000083C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1192167, RefRangeEnd = 1192169, XrefRangeStart = 1192157, XrefRangeEnd = 1192167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeName(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelWalker.NativeMethodInfoPtr_GetTypeName_Private_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002AF2 File Offset: 0x00000CF2
		public ModelWalker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000A210 File Offset: 0x00008410
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00002AFB File Offset: 0x00000CFB
		public unsafe DataWriterSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelWalker.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataWriterSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModelWalker.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Public_Virtual_Final_New_IEnumerable_1_Token_Object_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Protected_Virtual_New_Void_List_1_Token_ICycleDetector_Object_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayTokens_Protected_Void_List_1_Token_ICycleDetector_IEnumerable_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectTokens_Protected_Void_List_1_Token_ICycleDetector_String_IDictionaryEnumerator_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectTokens_Protected_Void_List_1_Token_ICycleDetector_String_IEnumerator_1_KeyValuePair_2_String_Object_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectTokens_Protected_Void_List_1_Token_ICycleDetector_Type_Object_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Private_String_Object_0;
	}
}
