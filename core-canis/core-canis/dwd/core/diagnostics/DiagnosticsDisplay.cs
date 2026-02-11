using System;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.diagnostics
{
	// Token: 0x020001BC RID: 444
	public class DiagnosticsDisplay : MonoBehaviour
	{
		// Token: 0x060018A9 RID: 6313 RVA: 0x00076410 File Offset: 0x00074610
		// Note: this type is marked as 'beforefieldinit'.
		static DiagnosticsDisplay()
		{
			Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.diagnostics", "DiagnosticsDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr);
			DiagnosticsDisplay.NativeFieldInfoPtr_bytesInMebibyte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, "bytesInMebibyte");
			DiagnosticsDisplay.NativeFieldInfoPtr_UpdateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, "UpdateFrequency");
			DiagnosticsDisplay.NativeFieldInfoPtr_fpsTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, "fpsTracker");
			DiagnosticsDisplay.NativeFieldInfoPtr_memoryTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, "memoryTracker");
			DiagnosticsDisplay.NativeFieldInfoPtr_sessionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, "sessionProvider");
			DiagnosticsDisplay.NativeFieldInfoPtr_elapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, "elapsed");
			DiagnosticsDisplay.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, "visible");
			DiagnosticsDisplay.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667236);
			DiagnosticsDisplay.NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667237);
			DiagnosticsDisplay.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667238);
			DiagnosticsDisplay.NativeMethodInfoPtr_initialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667239);
			DiagnosticsDisplay.NativeMethodInfoPtr_visibilityChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667240);
			DiagnosticsDisplay.NativeMethodInfoPtr_GetFingerCount_Private_Static_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667241);
			DiagnosticsDisplay.NativeMethodInfoPtr_ShouldToggle_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667242);
			DiagnosticsDisplay.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667243);
			DiagnosticsDisplay.NativeMethodInfoPtr_UpdateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667244);
			DiagnosticsDisplay.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667245);
			DiagnosticsDisplay.NativeMethodInfoPtr_SetFps_Protected_Abstract_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667246);
			DiagnosticsDisplay.NativeMethodInfoPtr_SetMemory_Protected_Abstract_Virtual_New_Void_UInt64_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667247);
			DiagnosticsDisplay.NativeMethodInfoPtr_SetPing_Protected_Abstract_Virtual_New_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667248);
			DiagnosticsDisplay.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr, 100667249);
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x000765E4 File Offset: 0x000747E4
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x00076620 File Offset: 0x00074820
		public unsafe bool Visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsDisplay.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880675, XrefRangeEnd = 880677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsDisplay.NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00076660 File Offset: 0x00074860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880677, XrefRangeEnd = 880697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsDisplay.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00076694 File Offset: 0x00074894
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DiagnosticsDisplay.NativeMethodInfoPtr_initialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x000766D0 File Offset: 0x000748D0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void visibilityChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DiagnosticsDisplay.NativeMethodInfoPtr_visibilityChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0007670C File Offset: 0x0007490C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880697, XrefRangeEnd = 880704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFingerCount(out bool touchBegan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &touchBegan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsDisplay.NativeMethodInfoPtr_GetFingerCount_Private_Static_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0007674C File Offset: 0x0007494C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880704, XrefRangeEnd = 880709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldToggle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsDisplay.NativeMethodInfoPtr_ShouldToggle_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0007677C File Offset: 0x0007497C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880709, XrefRangeEnd = 880729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsDisplay.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000767B0 File Offset: 0x000749B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 880730, RefRangeEnd = 880733, XrefRangeStart = 880729, XrefRangeEnd = 880730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsDisplay.NativeMethodInfoPtr_UpdateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000767E4 File Offset: 0x000749E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880733, XrefRangeEnd = 880734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsDisplay.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00076818 File Offset: 0x00074A18
		[CallerCount(0)]
		public unsafe virtual void SetFps(int current, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DiagnosticsDisplay.NativeMethodInfoPtr_SetFps_Protected_Abstract_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00076880 File Offset: 0x00074A80
		[CallerCount(0)]
		public unsafe virtual void SetMemory(ulong current, ulong min, ulong max, ulong free, ulong profiler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref free;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref profiler;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DiagnosticsDisplay.NativeMethodInfoPtr_SetMemory_Protected_Abstract_Virtual_New_Void_UInt64_UInt64_UInt64_UInt64_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00076904 File Offset: 0x00074B04
		[CallerCount(0)]
		public unsafe virtual void SetPing(double latencyAverage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref latencyAverage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DiagnosticsDisplay.NativeMethodInfoPtr_SetPing_Protected_Abstract_Virtual_New_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00076950 File Offset: 0x00074B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiagnosticsDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiagnosticsDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsDisplay.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0000AD6B File Offset: 0x00008F6B
		public DiagnosticsDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x0007698C File Offset: 0x00074B8C
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x0000AD74 File Offset: 0x00008F74
		public unsafe static ulong bytesInMebibyte
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DiagnosticsDisplay.NativeFieldInfoPtr_bytesInMebibyte, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiagnosticsDisplay.NativeFieldInfoPtr_bytesInMebibyte, (void*)(&value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x000769A8 File Offset: 0x00074BA8
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x0000AD82 File Offset: 0x00008F82
		public unsafe float UpdateFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_UpdateFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_UpdateFrequency)) = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x000769D0 File Offset: 0x00074BD0
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x0000AD9D File Offset: 0x00008F9D
		public unsafe FPSTracker fpsTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_fpsTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FPSTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_fpsTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x00076A00 File Offset: 0x00074C00
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x0000ADBC File Offset: 0x00008FBC
		public unsafe MemoryTracker memoryTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_memoryTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_memoryTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x00076A30 File Offset: 0x00074C30
		// (set) Token: 0x060018C2 RID: 6338 RVA: 0x0000ADDB File Offset: 0x00008FDB
		public unsafe SessionProvider sessionProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_sessionProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_sessionProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x00076A60 File Offset: 0x00074C60
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0000ADFA File Offset: 0x00008FFA
		public unsafe float elapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_elapsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_elapsed)) = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x00076A88 File Offset: 0x00074C88
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0000AE15 File Offset: 0x00009015
		public unsafe bool visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticsDisplay.NativeFieldInfoPtr_visible)) = value;
			}
		}

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeFieldInfoPtr_bytesInMebibyte;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeFieldInfoPtr_UpdateFrequency;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeFieldInfoPtr_fpsTracker;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeFieldInfoPtr_memoryTracker;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeFieldInfoPtr_sessionProvider;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeFieldInfoPtr_elapsed;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeFieldInfoPtr_visible;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_New_Void_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_visibilityChanged_Protected_Virtual_New_Void_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_GetFingerCount_Private_Static_Int32_byref_Boolean_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_ShouldToggle_Private_Static_Boolean_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Private_Void_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_SetFps_Protected_Abstract_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_SetMemory_Protected_Abstract_Virtual_New_Void_UInt64_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_SetPing_Protected_Abstract_Virtual_New_Void_Double_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
