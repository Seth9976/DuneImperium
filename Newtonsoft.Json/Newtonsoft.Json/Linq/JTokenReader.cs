using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C5 RID: 197
	public class JTokenReader : JsonReader
	{
		// Token: 0x0600125B RID: 4699 RVA: 0x000660CC File Offset: 0x000642CC
		// Note: this type is marked as 'beforefieldinit'.
		static JTokenReader()
		{
			Il2CppClassPointerStore<JTokenReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JTokenReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr);
			JTokenReader.NativeFieldInfoPtr__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, "_root");
			JTokenReader.NativeFieldInfoPtr__initialPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, "_initialPath");
			JTokenReader.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, "_parent");
			JTokenReader.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, "_current");
			JTokenReader.NativeMethodInfoPtr_get_CurrentToken_Public_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666744);
			JTokenReader.NativeMethodInfoPtr__ctor_Public_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666745);
			JTokenReader.NativeMethodInfoPtr__ctor_Public_Void_JToken_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666746);
			JTokenReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666747);
			JTokenReader.NativeMethodInfoPtr_ReadOver_Private_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666748);
			JTokenReader.NativeMethodInfoPtr_ReadToEnd_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666749);
			JTokenReader.NativeMethodInfoPtr_GetEndToken_Private_Nullable_1_JsonToken_JContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666750);
			JTokenReader.NativeMethodInfoPtr_ReadInto_Private_Boolean_JContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666751);
			JTokenReader.NativeMethodInfoPtr_SetEnd_Private_Boolean_JContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666752);
			JTokenReader.NativeMethodInfoPtr_SetToken_Private_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666753);
			JTokenReader.NativeMethodInfoPtr_SafeToString_Private_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666754);
			JTokenReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666755);
			JTokenReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666756);
			JTokenReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666757);
			JTokenReader.NativeMethodInfoPtr_get_Path_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr, 100666758);
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x00066278 File Offset: 0x00064478
		public unsafe JToken CurrentToken
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_get_CurrentToken_Public_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000662B8 File Offset: 0x000644B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 761288, RefRangeEnd = 761290, XrefRangeStart = 761283, XrefRangeEnd = 761288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JTokenReader(JToken token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr__ctor_Public_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00066304 File Offset: 0x00064504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761290, XrefRangeEnd = 761296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JTokenReader(JToken token, string initialPath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JTokenReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr__ctor_Public_Void_JToken_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00066364 File Offset: 0x00064564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761296, XrefRangeEnd = 761299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JTokenReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000663AC File Offset: 0x000645AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 761301, RefRangeEnd = 761302, XrefRangeStart = 761299, XrefRangeEnd = 761301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadOver(JToken t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_ReadOver_Private_Boolean_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000663FC File Offset: 0x000645FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761302, XrefRangeEnd = 761304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_ReadToEnd_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00066438 File Offset: 0x00064638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761304, XrefRangeEnd = 761305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<JsonToken> GetEndToken(JContainer c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_GetEndToken_Private_Nullable_1_JsonToken_JContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<JsonToken>(intPtr);
			}
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00066480 File Offset: 0x00064680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761305, XrefRangeEnd = 761308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadInto(JContainer c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_ReadInto_Private_Boolean_JContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000664D0 File Offset: 0x000646D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761308, XrefRangeEnd = 761320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetEnd(JContainer c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_SetEnd_Private_Boolean_JContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00066520 File Offset: 0x00064720
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 761355, RefRangeEnd = 761358, XrefRangeStart = 761320, XrefRangeEnd = 761355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToken(JToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_SetToken_Private_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00066564 File Offset: 0x00064764
		[CallerCount(0)]
		public unsafe string SafeToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_SafeToString_Private_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000665AC File Offset: 0x000647AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761358, XrefRangeEnd = 761361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Newtonsoft_Json_IJsonLineInfo_HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x000665E8 File Offset: 0x000647E8
		public unsafe virtual int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761361, XrefRangeEnd = 761364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00066624 File Offset: 0x00064824
		public unsafe virtual int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761364, XrefRangeEnd = 761367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00066660 File Offset: 0x00064860
		public unsafe override string Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761367, XrefRangeEnd = 761376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JTokenReader.NativeMethodInfoPtr_get_Path_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00007BC7 File Offset: 0x00005DC7
		public JTokenReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x000666A4 File Offset: 0x000648A4
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x00007BD0 File Offset: 0x00005DD0
		public unsafe JToken _root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JTokenReader.NativeFieldInfoPtr__root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JTokenReader.NativeFieldInfoPtr__root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x000666D4 File Offset: 0x000648D4
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x00007BEF File Offset: 0x00005DEF
		public unsafe string _initialPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JTokenReader.NativeFieldInfoPtr__initialPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JTokenReader.NativeFieldInfoPtr__initialPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x000666FC File Offset: 0x000648FC
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x00007C0E File Offset: 0x00005E0E
		public unsafe JToken _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JTokenReader.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JTokenReader.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x0006672C File Offset: 0x0006492C
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x00007C2D File Offset: 0x00005E2D
		public unsafe JToken _current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JTokenReader.NativeFieldInfoPtr__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JTokenReader.NativeFieldInfoPtr__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeFieldInfoPtr__root;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeFieldInfoPtr__initialPath;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeFieldInfoPtr__current;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentToken_Public_get_JToken_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JToken_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JToken_String_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_ReadOver_Private_Boolean_JToken_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Private_Boolean_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_GetEndToken_Private_Nullable_1_JsonToken_JContainer_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_ReadInto_Private_Boolean_JContainer_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_SetEnd_Private_Boolean_JContainer_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_SetToken_Private_Void_JToken_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_SafeToString_Private_String_Object_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_Virtual_get_String_0;
	}
}
