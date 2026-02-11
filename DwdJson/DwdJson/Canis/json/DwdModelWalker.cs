using System;
using Canis.json.tokenizers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using JsonFx.Model;
using JsonFx.Serialization;
using JsonFx.Serialization.GraphCycles;

namespace Canis.json
{
	// Token: 0x02000015 RID: 21
	public sealed class DwdModelWalker : ModelWalker
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00004778 File Offset: 0x00002978
		// Note: this type is marked as 'beforefieldinit'.
		static DwdModelWalker()
		{
			Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "DwdModelWalker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr);
			DwdModelWalker.NativeFieldInfoPtr_TypeHintingAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr, "TypeHintingAttributeType");
			DwdModelWalker.NativeFieldInfoPtr_DwdJsonMessageAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr, "DwdJsonMessageAttributeType");
			DwdModelWalker.NativeFieldInfoPtr_TypedIDType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr, "TypedIDType");
			DwdModelWalker.NativeFieldInfoPtr_Tokenizers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr, "Tokenizers");
			DwdModelWalker.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr, 100663359);
			DwdModelWalker.NativeMethodInfoPtr_Reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr, 100663360);
			DwdModelWalker.NativeMethodInfoPtr_RegisterTypeTokenizer_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr, 100663361);
			DwdModelWalker.NativeMethodInfoPtr_GetTokens_Public_Void_List_1_Token_ICycleDetector_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr, 100663362);
			DwdModelWalker.NativeMethodInfoPtr_GetTokens_Protected_Virtual_Void_List_1_Token_ICycleDetector_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr, 100663363);
			DwdModelWalker.NativeMethodInfoPtr_TryTokenizers_Private_Boolean_ICycleDetector_List_1_Token_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr, 100663364);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004870 File Offset: 0x00002A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248564, XrefRangeEnd = 1248565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdModelWalker(DataWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdModelWalker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelWalker.NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000048BC File Offset: 0x00002ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248565, XrefRangeEnd = 1248573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelWalker.NativeMethodInfoPtr_Reset_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000048E4 File Offset: 0x00002AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1248589, RefRangeEnd = 1248590, XrefRangeStart = 1248573, XrefRangeEnd = 1248589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTypeTokenizer(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelWalker.NativeMethodInfoPtr_RegisterTypeTokenizer_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000491C File Offset: 0x00002B1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1248692, RefRangeEnd = 1248699, XrefRangeStart = 1248590, XrefRangeEnd = 1248692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTokens(List<Token> tokens, ICycleDetector detector, Type type, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelWalker.NativeMethodInfoPtr_GetTokens_Public_Void_List_1_Token_ICycleDetector_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004998 File Offset: 0x00002B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248699, XrefRangeEnd = 1248702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetTokens(List<Token> tokens, ICycleDetector detector, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelWalker.NativeMethodInfoPtr_GetTokens_Protected_Virtual_Void_List_1_Token_ICycleDetector_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004A00 File Offset: 0x00002C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1248715, RefRangeEnd = 1248716, XrefRangeStart = 1248702, XrefRangeEnd = 1248715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryTokenizers(ICycleDetector detector, List<Token> tokens, Type type, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(detector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelWalker.NativeMethodInfoPtr_TryTokenizers_Private_Boolean_ICycleDetector_List_1_Token_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000245B File Offset: 0x0000065B
		public DwdModelWalker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004A84 File Offset: 0x00002C84
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002464 File Offset: 0x00000664
		public unsafe static Type TypeHintingAttributeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelWalker.NativeFieldInfoPtr_TypeHintingAttributeType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelWalker.NativeFieldInfoPtr_TypeHintingAttributeType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004AAC File Offset: 0x00002CAC
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002476 File Offset: 0x00000676
		public unsafe static Type DwdJsonMessageAttributeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelWalker.NativeFieldInfoPtr_DwdJsonMessageAttributeType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelWalker.NativeFieldInfoPtr_DwdJsonMessageAttributeType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004AD4 File Offset: 0x00002CD4
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002488 File Offset: 0x00000688
		public unsafe static Type TypedIDType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelWalker.NativeFieldInfoPtr_TypedIDType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelWalker.NativeFieldInfoPtr_TypedIDType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004AFC File Offset: 0x00002CFC
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000249A File Offset: 0x0000069A
		public unsafe static Dictionary<Type, DwdTypeTokenizer> Tokenizers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelWalker.NativeFieldInfoPtr_Tokenizers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, DwdTypeTokenizer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelWalker.NativeFieldInfoPtr_Tokenizers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_TypeHintingAttributeType;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_DwdJsonMessageAttributeType;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_TypedIDType;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_Tokenizers;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataWriterSettings_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTypeTokenizer_Public_Static_Void_Type_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Public_Void_List_1_Token_ICycleDetector_Type_Object_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Protected_Virtual_Void_List_1_Token_ICycleDetector_Object_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_TryTokenizers_Private_Boolean_ICycleDetector_List_1_Token_Type_Object_0;
	}
}
