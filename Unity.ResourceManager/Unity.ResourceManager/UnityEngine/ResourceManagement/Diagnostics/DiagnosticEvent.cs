using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.Diagnostics
{
	// Token: 0x0200004A RID: 74
	[Serializable]
	public sealed class DiagnosticEvent : ValueType
	{
		// Token: 0x060003AD RID: 941 RVA: 0x000132B0 File Offset: 0x000114B0
		// Note: this type is marked as 'beforefieldinit'.
		static DiagnosticEvent()
		{
			Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Diagnostics", "DiagnosticEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr);
			DiagnosticEvent.NativeFieldInfoPtr_m_Graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, "m_Graph");
			DiagnosticEvent.NativeFieldInfoPtr_m_Dependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, "m_Dependencies");
			DiagnosticEvent.NativeFieldInfoPtr_m_ObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, "m_ObjectId");
			DiagnosticEvent.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, "m_DisplayName");
			DiagnosticEvent.NativeFieldInfoPtr_m_Stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, "m_Stream");
			DiagnosticEvent.NativeFieldInfoPtr_m_Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, "m_Frame");
			DiagnosticEvent.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, "m_Value");
			DiagnosticEvent.NativeMethodInfoPtr_get_Graph_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, 100663924);
			DiagnosticEvent.NativeMethodInfoPtr_get_ObjectId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, 100663925);
			DiagnosticEvent.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, 100663926);
			DiagnosticEvent.NativeMethodInfoPtr_get_Dependencies_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, 100663927);
			DiagnosticEvent.NativeMethodInfoPtr_get_Stream_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, 100663928);
			DiagnosticEvent.NativeMethodInfoPtr_get_Frame_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, 100663929);
			DiagnosticEvent.NativeMethodInfoPtr_get_Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, 100663930);
			DiagnosticEvent.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, 100663931);
			DiagnosticEvent.NativeMethodInfoPtr_Serialize_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, 100663932);
			DiagnosticEvent.NativeMethodInfoPtr_Deserialize_Public_Static_DiagnosticEvent_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr, 100663933);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00013434 File Offset: 0x00011634
		public unsafe string Graph
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEvent.NativeMethodInfoPtr_get_Graph_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00013470 File Offset: 0x00011670
		public unsafe int ObjectId
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEvent.NativeMethodInfoPtr_get_ObjectId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x000134B4 File Offset: 0x000116B4
		public unsafe string DisplayName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEvent.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x000134F0 File Offset: 0x000116F0
		public unsafe Il2CppStructArray<int> Dependencies
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEvent.NativeMethodInfoPtr_get_Dependencies_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00013534 File Offset: 0x00011734
		public unsafe int Stream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEvent.NativeMethodInfoPtr_get_Stream_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00013578 File Offset: 0x00011778
		public unsafe int Frame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEvent.NativeMethodInfoPtr_get_Frame_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x000135BC File Offset: 0x000117BC
		public unsafe int Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEvent.NativeMethodInfoPtr_get_Value_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00013600 File Offset: 0x00011800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1141493, RefRangeEnd = 1141495, XrefRangeStart = 1141490, XrefRangeEnd = 1141493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiagnosticEvent(string graph, string name, int id, int stream, int frame, int value, Il2CppStructArray<int> deps)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(graph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frame;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEvent.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000136B0 File Offset: 0x000118B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141500, RefRangeEnd = 1141501, XrefRangeStart = 1141495, XrefRangeEnd = 1141500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEvent.NativeMethodInfoPtr_Serialize_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000136F4 File Offset: 0x000118F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141501, XrefRangeEnd = 1141505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DiagnosticEvent Deserialize(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEvent.NativeMethodInfoPtr_Deserialize_Public_Static_DiagnosticEvent_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DiagnosticEvent(intPtr);
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00003748 File Offset: 0x00001948
		public DiagnosticEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00003751 File Offset: 0x00001951
		public DiagnosticEvent()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiagnosticEvent>.NativeClassPtr))
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00013730 File Offset: 0x00011930
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00003763 File Offset: 0x00001963
		public unsafe string m_Graph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_Graph);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_Graph), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00013758 File Offset: 0x00011958
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00003782 File Offset: 0x00001982
		public unsafe Il2CppStructArray<int> m_Dependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_Dependencies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_Dependencies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00013788 File Offset: 0x00011988
		// (set) Token: 0x060003BF RID: 959 RVA: 0x000037A1 File Offset: 0x000019A1
		public unsafe int m_ObjectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_ObjectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_ObjectId)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x000137B0 File Offset: 0x000119B0
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x000037BC File Offset: 0x000019BC
		public unsafe string m_DisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_DisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_DisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000137D8 File Offset: 0x000119D8
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x000037DB File Offset: 0x000019DB
		public unsafe int m_Stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_Stream);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_Stream)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00013800 File Offset: 0x00011A00
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000037F6 File Offset: 0x000019F6
		public unsafe int m_Frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_Frame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_Frame)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00013828 File Offset: 0x00011A28
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00003811 File Offset: 0x00001A11
		public unsafe int m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEvent.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr_m_Graph;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_m_Dependencies;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectId;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayName;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_m_Stream;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_m_Frame;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_get_Graph_Public_get_String_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectId_Public_get_Int32_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_get_Dependencies_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_get_Stream_Public_get_Int32_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_get_Frame_Public_get_Int32_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int32_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_DiagnosticEvent_Il2CppStructArray_1_Byte_0;
	}
}
