using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem
{
	// Token: 0x02000134 RID: 308
	public static class GC : Object
	{
		// Token: 0x060014C7 RID: 5319 RVA: 0x0008A660 File Offset: 0x00088860
		// Note: this type is marked as 'beforefieldinit'.
		static GC()
		{
			Il2CppClassPointerStore<GC>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "GC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GC>.NativeClassPtr);
			GC.NativeFieldInfoPtr_EPHEMERON_TOMBSTONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GC>.NativeClassPtr, "EPHEMERON_TOMBSTONE");
			GC.NativeMethodInfoPtr_GetCollectionCount_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666991);
			GC.NativeMethodInfoPtr_GetMaxGeneration_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666992);
			GC.NativeMethodInfoPtr_InternalCollect_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666993);
			GC.NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666994);
			GC.NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666995);
			GC.NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666996);
			GC.NativeMethodInfoPtr_GetMemoryInfo_Internal_Static_Void_byref_UInt32_byref_UInt64_byref_UInt32_byref_UIntPtr_byref_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666997);
			GC.NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666998);
			GC.NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100666999);
			GC.NativeMethodInfoPtr_Collect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100667000);
			GC.NativeMethodInfoPtr_CollectionCount_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100667001);
			GC.NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100667002);
			GC.NativeMethodInfoPtr_get_MaxGeneration_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100667003);
			GC.NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100667004);
			GC.NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100667005);
			GC.NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100667006);
			GC.NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100667007);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0008A7F8 File Offset: 0x000889F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341679, XrefRangeEnd = 1341680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCollectionCount(int generation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref generation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_GetCollectionCount_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0008A838 File Offset: 0x00088A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341680, XrefRangeEnd = 1341681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxGeneration()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_GetMaxGeneration_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0008A868 File Offset: 0x00088A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341681, XrefRangeEnd = 1341682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalCollect(int generation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref generation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_InternalCollect_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0008A89C File Offset: 0x00088A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341682, XrefRangeEnd = 1341683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordPressure(long bytesAllocated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytesAllocated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0008A8D0 File Offset: 0x00088AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1341684, RefRangeEnd = 1341685, XrefRangeStart = 1341683, XrefRangeEnd = 1341684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void register_ephemeron_array(Il2CppReferenceArray<Ephemeron> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0008A908 File Offset: 0x00088B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341685, XrefRangeEnd = 1341686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object get_ephemeron_tombstone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0008A93C File Offset: 0x00088B3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1341686, RefRangeEnd = 1341689, XrefRangeStart = 1341686, XrefRangeEnd = 1341686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &highMemLoadThreshold;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &totalPhysicalMem;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastRecordedMemLoad;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastRecordedHeapSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastRecordedFragmentation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_GetMemoryInfo_Internal_Static_Void_byref_UInt32_byref_UInt64_byref_UInt32_byref_UIntPtr_byref_UIntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0008A9A8 File Offset: 0x00088BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1341710, RefRangeEnd = 1341712, XrefRangeStart = 1341689, XrefRangeEnd = 1341710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddMemoryPressure(long bytesAllocated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytesAllocated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0008A9DC File Offset: 0x00088BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1341733, RefRangeEnd = 1341734, XrefRangeStart = 1341712, XrefRangeEnd = 1341733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveMemoryPressure(long bytesAllocated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytesAllocated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0008AA10 File Offset: 0x00088C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341734, XrefRangeEnd = 1341742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Collect()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_Collect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0008AA38 File Offset: 0x00088C38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1341754, RefRangeEnd = 1341756, XrefRangeStart = 1341742, XrefRangeEnd = 1341754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CollectionCount(int generation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref generation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_CollectionCount_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0008AA78 File Offset: 0x00088C78
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KeepAlive(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x0008AAB0 File Offset: 0x00088CB0
		public unsafe static int MaxGeneration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341756, XrefRangeEnd = 1341760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_get_MaxGeneration_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0008AAE0 File Offset: 0x00088CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341760, XrefRangeEnd = 1341766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SuppressFinalize(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0008AB18 File Offset: 0x00088D18
		[CallerCount(138)]
		[CachedScanResults(RefRangeStart = 1341776, RefRangeEnd = 1341914, XrefRangeStart = 1341766, XrefRangeEnd = 1341776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SuppressFinalize(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0008AB50 File Offset: 0x00088D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341914, XrefRangeEnd = 1341915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ReRegisterForFinalize(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0008AB88 File Offset: 0x00088D88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1341925, RefRangeEnd = 1341928, XrefRangeStart = 1341915, XrefRangeEnd = 1341925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReRegisterForFinalize(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000068FB File Offset: 0x00004AFB
		public GC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x0008ABC0 File Offset: 0x00088DC0
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x00006904 File Offset: 0x00004B04
		public unsafe static Object EPHEMERON_TOMBSTONE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GC.NativeFieldInfoPtr_EPHEMERON_TOMBSTONE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GC.NativeFieldInfoPtr_EPHEMERON_TOMBSTONE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeFieldInfoPtr_EPHEMERON_TOMBSTONE;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_GetCollectionCount_Private_Static_Int32_Int32_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxGeneration_Private_Static_Int32_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_InternalCollect_Private_Static_Void_Int32_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_GetMemoryInfo_Internal_Static_Void_byref_UInt32_byref_UInt64_byref_UInt32_byref_UIntPtr_byref_UIntPtr_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_Collect_Public_Static_Void_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_CollectionCount_Public_Static_Int32_Int32_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxGeneration_Public_Static_get_Int32_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0;
	}
}
