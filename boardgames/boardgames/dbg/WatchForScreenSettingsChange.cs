using System;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dbg
{
	// Token: 0x02000029 RID: 41
	public class WatchForScreenSettingsChange : MonoBehaviour
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00014D30 File Offset: 0x00012F30
		// Note: this type is marked as 'beforefieldinit'.
		static WatchForScreenSettingsChange()
		{
			Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dbg", "WatchForScreenSettingsChange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr);
			WatchForScreenSettingsChange.NativeFieldInfoPtr_lastAcceptedResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, "lastAcceptedResolution");
			WatchForScreenSettingsChange.NativeFieldInfoPtr_confirmOrRevertCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, "confirmOrRevertCommand");
			WatchForScreenSettingsChange.NativeFieldInfoPtr_autoConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, "autoConfirm");
			WatchForScreenSettingsChange.NativeFieldInfoPtr_lastAcceptedFullscreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, "lastAcceptedFullscreen");
			WatchForScreenSettingsChange.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663546);
			WatchForScreenSettingsChange.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663547);
			WatchForScreenSettingsChange.NativeMethodInfoPtr_IScreenResizeHandler_PreScreenResize_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663548);
			WatchForScreenSettingsChange.NativeMethodInfoPtr_IScreenResizeHandler_PostScreenResize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663549);
			WatchForScreenSettingsChange.NativeMethodInfoPtr_confirmOrRevert_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663550);
			WatchForScreenSettingsChange.NativeMethodInfoPtr_getClosestSupportedResolution_Private_ScreenResolution_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663551);
			WatchForScreenSettingsChange.NativeMethodInfoPtr_confirmCurrentScreenSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663552);
			WatchForScreenSettingsChange.NativeMethodInfoPtr_AutoConfirmNextScreenChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663553);
			WatchForScreenSettingsChange.NativeMethodInfoPtr_IsStandalone_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663554);
			WatchForScreenSettingsChange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663555);
			WatchForScreenSettingsChange.NativeMethodInfoPtr__Update_b__5_0_Private_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, 100663556);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00014E8C File Offset: 0x0001308C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983650, XrefRangeEnd = 983651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00014EC0 File Offset: 0x000130C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983651, XrefRangeEnd = 983675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00014EF4 File Offset: 0x000130F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983675, XrefRangeEnd = 983679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator IScreenResizeHandler_PreScreenResize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr_IScreenResizeHandler_PreScreenResize_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00014F34 File Offset: 0x00013134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983679, XrefRangeEnd = 983683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void IScreenResizeHandler_PostScreenResize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr_IScreenResizeHandler_PostScreenResize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00014F68 File Offset: 0x00013168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 983688, RefRangeEnd = 983690, XrefRangeStart = 983683, XrefRangeEnd = 983688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator confirmOrRevert(bool autoRevert = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoRevert;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr_confirmOrRevert_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00014FB4 File Offset: 0x000131B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983690, XrefRangeEnd = 983709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenResolution getClosestSupportedResolution(ScreenResolution desiredResolution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desiredResolution;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr_getClosestSupportedResolution_Private_ScreenResolution_ScreenResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00015000 File Offset: 0x00013200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 983750, RefRangeEnd = 983751, XrefRangeStart = 983709, XrefRangeEnd = 983750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void confirmCurrentScreenSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr_confirmCurrentScreenSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00015034 File Offset: 0x00013234
		[CallerCount(0)]
		public unsafe void AutoConfirmNextScreenChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr_AutoConfirmNextScreenChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00015068 File Offset: 0x00013268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 983761, RefRangeEnd = 983763, XrefRangeStart = 983751, XrefRangeEnd = 983761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStandalone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr_IsStandalone_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000150A4 File Offset: 0x000132A4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WatchForScreenSettingsChange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000150E0 File Offset: 0x000132E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983763, XrefRangeEnd = 983764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Update_b__5_0(Command cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.NativeMethodInfoPtr__Update_b__5_0_Private_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002A5C File Offset: 0x00000C5C
		public WatchForScreenSettingsChange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00015130 File Offset: 0x00013330
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002A65 File Offset: 0x00000C65
		public unsafe ScreenResolution lastAcceptedResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.NativeFieldInfoPtr_lastAcceptedResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.NativeFieldInfoPtr_lastAcceptedResolution)) = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00015158 File Offset: 0x00013358
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002A80 File Offset: 0x00000C80
		public unsafe Command confirmOrRevertCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.NativeFieldInfoPtr_confirmOrRevertCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.NativeFieldInfoPtr_confirmOrRevertCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00015188 File Offset: 0x00013388
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002A9F File Offset: 0x00000C9F
		public unsafe bool autoConfirm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.NativeFieldInfoPtr_autoConfirm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.NativeFieldInfoPtr_autoConfirm)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000151B0 File Offset: 0x000133B0
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002ABA File Offset: 0x00000CBA
		public unsafe bool lastAcceptedFullscreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.NativeFieldInfoPtr_lastAcceptedFullscreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.NativeFieldInfoPtr_lastAcceptedFullscreen)) = value;
			}
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_lastAcceptedResolution;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_confirmOrRevertCommand;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_autoConfirm;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_lastAcceptedFullscreen;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_IScreenResizeHandler_PreScreenResize_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_IScreenResizeHandler_PostScreenResize_Private_Virtual_Final_New_Void_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_confirmOrRevert_Private_IEnumerator_Boolean_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_getClosestSupportedResolution_Private_ScreenResolution_ScreenResolution_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_confirmCurrentScreenSettings_Private_Void_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_AutoConfirmNextScreenChange_Public_Void_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_IsStandalone_Private_Boolean_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr__Update_b__5_0_Private_Boolean_Command_0;

		// Token: 0x020001A0 RID: 416
		[ObfuscatedName("dbg.WatchForScreenSettingsChange+<IScreenResizeHandler-PreScreenResize>d__6")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : global::Il2CppSystem.Object
		{
			// Token: 0x06001457 RID: 5207 RVA: 0x0004FCB8 File Offset: 0x0004DEB8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
			{
				Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, "<IScreenResizeHandler-PreScreenResize>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
				WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
				WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
				WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663557);
				WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663558);
				WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663559);
				WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663560);
				WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663561);
				WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100663562);
			}

			// Token: 0x06001458 RID: 5208 RVA: 0x0004FD84 File Offset: 0x0004DF84
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001459 RID: 5209 RVA: 0x0004FDCC File Offset: 0x0004DFCC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600145A RID: 5210 RVA: 0x0004FE00 File Offset: 0x0004E000
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005CA RID: 1482
			// (get) Token: 0x0600145B RID: 5211 RVA: 0x0004FE3C File Offset: 0x0004E03C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600145C RID: 5212 RVA: 0x0004FE7C File Offset: 0x0004E07C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983571, XrefRangeEnd = 983576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x0600145D RID: 5213 RVA: 0x0004FEB0 File Offset: 0x0004E0B0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600145E RID: 5214 RVA: 0x0000B85F File Offset: 0x00009A5F
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x0600145F RID: 5215 RVA: 0x0004FEF0 File Offset: 0x0004E0F0
			// (set) Token: 0x06001460 RID: 5216 RVA: 0x0000B868 File Offset: 0x00009A68
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x06001461 RID: 5217 RVA: 0x0004FF18 File Offset: 0x0004E118
			// (set) Token: 0x06001462 RID: 5218 RVA: 0x0000B883 File Offset: 0x00009A83
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C57 RID: 3159
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C58 RID: 3160
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C59 RID: 3161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C5A RID: 3162
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C5B RID: 3163
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C5C RID: 3164
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C5D RID: 3165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C5E RID: 3166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001A1 RID: 417
		[ObfuscatedName("dbg.WatchForScreenSettingsChange+<confirmOrRevert>d__8")]
		public sealed class _confirmOrRevert_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06001463 RID: 5219 RVA: 0x0004FF48 File Offset: 0x0004E148
			// Note: this type is marked as 'beforefieldinit'.
			static _confirmOrRevert_d__8()
			{
				Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WatchForScreenSettingsChange>.NativeClassPtr, "<confirmOrRevert>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr);
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, "<>1__state");
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, "<>2__current");
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, "<>4__this");
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr_autoRevert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, "autoRevert");
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__revertRes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, "<revertRes>5__2");
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__description_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, "<description>5__3");
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__timer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, "<timer>5__4");
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__confirmOrDeny_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, "<confirmOrDeny>5__5");
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, 100663563);
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, 100663564);
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, 100663565);
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, 100663566);
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, 100663567);
				WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr, 100663568);
			}

			// Token: 0x06001464 RID: 5220 RVA: 0x0005008C File Offset: 0x0004E28C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _confirmOrRevert_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WatchForScreenSettingsChange._confirmOrRevert_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001465 RID: 5221 RVA: 0x000500D4 File Offset: 0x0004E2D4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001466 RID: 5222 RVA: 0x00050108 File Offset: 0x0004E308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983576, XrefRangeEnd = 983645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005D4 RID: 1492
			// (get) Token: 0x06001467 RID: 5223 RVA: 0x00050144 File Offset: 0x0004E344
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001468 RID: 5224 RVA: 0x00050184 File Offset: 0x0004E384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983645, XrefRangeEnd = 983650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005D5 RID: 1493
			// (get) Token: 0x06001469 RID: 5225 RVA: 0x000501B8 File Offset: 0x0004E3B8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600146A RID: 5226 RVA: 0x0000B8A2 File Offset: 0x00009AA2
			public _confirmOrRevert_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005CC RID: 1484
			// (get) Token: 0x0600146B RID: 5227 RVA: 0x000501F8 File Offset: 0x0004E3F8
			// (set) Token: 0x0600146C RID: 5228 RVA: 0x0000B8AB File Offset: 0x00009AAB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005CD RID: 1485
			// (get) Token: 0x0600146D RID: 5229 RVA: 0x00050220 File Offset: 0x0004E420
			// (set) Token: 0x0600146E RID: 5230 RVA: 0x0000B8C6 File Offset: 0x00009AC6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CE RID: 1486
			// (get) Token: 0x0600146F RID: 5231 RVA: 0x00050250 File Offset: 0x0004E450
			// (set) Token: 0x06001470 RID: 5232 RVA: 0x0000B8E5 File Offset: 0x00009AE5
			public unsafe WatchForScreenSettingsChange __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WatchForScreenSettingsChange>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x06001471 RID: 5233 RVA: 0x00050280 File Offset: 0x0004E480
			// (set) Token: 0x06001472 RID: 5234 RVA: 0x0000B904 File Offset: 0x00009B04
			public unsafe bool autoRevert
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr_autoRevert);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr_autoRevert)) = value;
				}
			}

			// Token: 0x170005D0 RID: 1488
			// (get) Token: 0x06001473 RID: 5235 RVA: 0x000502A8 File Offset: 0x0004E4A8
			// (set) Token: 0x06001474 RID: 5236 RVA: 0x0000B91F File Offset: 0x00009B1F
			public unsafe ScreenResolution _revertRes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__revertRes_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__revertRes_5__2)) = value;
				}
			}

			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x06001475 RID: 5237 RVA: 0x000502D0 File Offset: 0x0004E4D0
			// (set) Token: 0x06001476 RID: 5238 RVA: 0x0000B93A File Offset: 0x00009B3A
			public unsafe BasicDescription _description_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__description_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__description_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D2 RID: 1490
			// (get) Token: 0x06001477 RID: 5239 RVA: 0x00050300 File Offset: 0x0004E500
			// (set) Token: 0x06001478 RID: 5240 RVA: 0x0000B959 File Offset: 0x00009B59
			public unsafe TimeSpan _timer_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__timer_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__timer_5__4)) = value;
				}
			}

			// Token: 0x170005D3 RID: 1491
			// (get) Token: 0x06001479 RID: 5241 RVA: 0x00050328 File Offset: 0x0004E528
			// (set) Token: 0x0600147A RID: 5242 RVA: 0x0000B974 File Offset: 0x00009B74
			public unsafe ConfirmOrDenyPrompt _confirmOrDeny_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__confirmOrDeny_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchForScreenSettingsChange._confirmOrRevert_d__8.NativeFieldInfoPtr__confirmOrDeny_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C5F RID: 3167
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C60 RID: 3168
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C61 RID: 3169
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000C62 RID: 3170
			private static readonly IntPtr NativeFieldInfoPtr_autoRevert;

			// Token: 0x04000C63 RID: 3171
			private static readonly IntPtr NativeFieldInfoPtr__revertRes_5__2;

			// Token: 0x04000C64 RID: 3172
			private static readonly IntPtr NativeFieldInfoPtr__description_5__3;

			// Token: 0x04000C65 RID: 3173
			private static readonly IntPtr NativeFieldInfoPtr__timer_5__4;

			// Token: 0x04000C66 RID: 3174
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDeny_5__5;

			// Token: 0x04000C67 RID: 3175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C68 RID: 3176
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C69 RID: 3177
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C6A RID: 3178
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C6B RID: 3179
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C6C RID: 3180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
