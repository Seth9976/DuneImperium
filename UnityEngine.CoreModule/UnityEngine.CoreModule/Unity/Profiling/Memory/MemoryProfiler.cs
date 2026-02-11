using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Profiling.Memory
{
	// Token: 0x02000027 RID: 39
	public static class MemoryProfiler : global::Il2CppSystem.Object
	{
		// Token: 0x06000157 RID: 343 RVA: 0x0001A108 File Offset: 0x00018308
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryProfiler()
		{
			Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.Memory", "MemoryProfiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr);
			MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "m_SnapshotFinished");
			MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "m_SaveScreenshotToDisk");
			MemoryProfiler.NativeFieldInfoPtr_CreatingMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "CreatingMetadata");
			MemoryProfiler.NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663422);
			MemoryProfiler.NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663423);
			MemoryProfiler.NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663424);
			MemoryProfiler.NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663425);
			MemoryProfiler.NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663426);
			MemoryProfiler.StartOperationDelegateField = IL2CPP.ResolveICall<MemoryProfiler.StartOperationDelegate>("Unity.Profiling.Memory.MemoryProfiler::StartOperation");
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0001A1E8 File Offset: 0x000183E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643412, XrefRangeEnd = 643436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PrepareMetadata()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0001A21C File Offset: 0x0001841C
		[CallerCount(0)]
		public unsafe static int WriteIntToByteArray(Il2CppStructArray<byte> array, int offset, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0001A27C File Offset: 0x0001847C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643436, XrefRangeEnd = 643437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteStringToByteArray(Il2CppStructArray<byte> array, int offset, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0001A2E0 File Offset: 0x000184E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643437, XrefRangeEnd = 643441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinalizeSnapshot(string path, bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0001A324 File Offset: 0x00018524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643441, XrefRangeEnd = 643448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, global::UnityEngine.TextureFormat format, int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002A3A File Offset: 0x00000C3A
		public MemoryProfiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0001A3B0 File Offset: 0x000185B0
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002A43 File Offset: 0x00000C43
		public unsafe static Action<string, bool> m_SnapshotFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0001A3D8 File Offset: 0x000185D8
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002A55 File Offset: 0x00000C55
		public unsafe static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool, DebugScreenCapture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0001A400 File Offset: 0x00018600
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002A67 File Offset: 0x00000C67
		public unsafe static Action<MemorySnapshotMetadata> CreatingMetadata
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_CreatingMetadata, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MemorySnapshotMetadata>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_CreatingMetadata, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002A79 File Offset: 0x00000C79
		public static void add_m_SnapshotFinished(Action<string, bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002A86 File Offset: 0x00000C86
		public static void remove_m_SnapshotFinished(Action<string, bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002A93 File Offset: 0x00000C93
		public static void add_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002AA0 File Offset: 0x00000CA0
		public static void remove_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002AAD File Offset: 0x00000CAD
		public static void add_CreatingMetadata(Action<MemorySnapshotMetadata> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002ABA File Offset: 0x00000CBA
		public static void remove_CreatingMetadata(Action<MemorySnapshotMetadata> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002AC7 File Offset: 0x00000CC7
		public static void StartOperation(uint captureFlag, bool requestScreenshot, string path, bool isRemote)
		{
			MemoryProfiler.StartOperationDelegateField(captureFlag, requestScreenshot, IL2CPP.ManagedStringToIl2Cpp(path), isRemote);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002ADC File Offset: 0x00000CDC
		public static void TakeSnapshot(string path, Action<string, bool> finishCallback, [Optional] CaptureFlags captureFlags)
		{
			MemoryProfiler.TakeSnapshot(path, finishCallback, null, captureFlags);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001A428 File Offset: 0x00018628
		public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, [Optional] CaptureFlags captureFlags)
		{
			bool flag = MemoryProfiler.m_SnapshotFinished != null;
			if (flag)
			{
				global::UnityEngine.Debug.LogWarning("Canceling snapshot, there is another snapshot in progress.");
				finishCallback.Invoke(path, false);
			}
			else
			{
				MemoryProfiler.add_m_SnapshotFinished(finishCallback);
				MemoryProfiler.add_m_SaveScreenshotToDisk(screenshotCallback);
				MemoryProfiler.StartOperation((uint)captureFlags, MemoryProfiler.m_SaveScreenshotToDisk != null, path, false);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002AE9 File Offset: 0x00000CE9
		public static void TakeTempSnapshot(Action<string, bool> finishCallback, [Optional] CaptureFlags captureFlags)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_m_SnapshotFinished;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_m_SaveScreenshotToDisk;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_CreatingMetadata;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0;

		// Token: 0x04000142 RID: 322
		private static readonly MemoryProfiler.StartOperationDelegate StartOperationDelegateField;

		// Token: 0x020003B8 RID: 952
		// (Invoke) Token: 0x0600304B RID: 12363
		private delegate void StartOperationDelegate(uint captureFlag, bool requestScreenshot, IntPtr path, bool isRemote);
	}
}
