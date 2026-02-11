using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace dwd.core.input.context
{
	// Token: 0x0200007B RID: 123
	public class InputContextManager : UIBehaviour
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x00016BD0 File Offset: 0x00014DD0
		// Note: this type is marked as 'beforefieldinit'.
		static InputContextManager()
		{
			Il2CppClassPointerStore<InputContextManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "InputContextManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr);
			InputContextManager.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, "version");
			InputContextManager.NativeFieldInfoPtr_cachedActiveContextVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, "cachedActiveContextVersion");
			InputContextManager.NativeFieldInfoPtr_nullContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, "nullContext");
			InputContextManager.NativeFieldInfoPtr_currentContextLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, "currentContextLayer");
			InputContextManager.NativeFieldInfoPtr_contextStacksByLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, "contextStacksByLayer");
			InputContextManager.NativeMethodInfoPtr_get_ActiveContext_Public_get_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663910);
			InputContextManager.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663911);
			InputContextManager.NativeMethodInfoPtr_PushContext_Public_Void_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663912);
			InputContextManager.NativeMethodInfoPtr_AddContext_Public_Void_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663913);
			InputContextManager.NativeMethodInfoPtr_RemoveContext_Public_Void_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663914);
			InputContextManager.NativeMethodInfoPtr_isContextInStack_Private_Boolean_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663915);
			InputContextManager.NativeMethodInfoPtr_pushContext_Private_Void_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663916);
			InputContextManager.NativeMethodInfoPtr_insertContext_Private_Void_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663917);
			InputContextManager.NativeMethodInfoPtr_addContext_Private_Void_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663918);
			InputContextManager.NativeMethodInfoPtr_updateCurrentContextLayer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663919);
			InputContextManager.NativeMethodInfoPtr_restoreLastSelectionForActiveContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663920);
			InputContextManager.NativeMethodInfoPtr_setInitialSelectionForActiveContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663921);
			InputContextManager.NativeMethodInfoPtr_RefreshSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663922);
			InputContextManager.NativeMethodInfoPtr_MarkDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663923);
			InputContextManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr, 100663924);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00016D90 File Offset: 0x00014F90
		public unsafe InputContext ActiveContext
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1123836, RefRangeEnd = 1123853, XrefRangeStart = 1123829, XrefRangeEnd = 1123836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_get_ActiveContext_Public_get_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr3) : null;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00016DD0 File Offset: 0x00014FD0
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123853, XrefRangeEnd = 1123854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00016E0C File Offset: 0x0001500C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123854, XrefRangeEnd = 1123855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushContext(InputContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_PushContext_Public_Void_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00016E50 File Offset: 0x00015050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1123863, RefRangeEnd = 1123865, XrefRangeStart = 1123855, XrefRangeEnd = 1123863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddContext(InputContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_AddContext_Public_Void_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00016E94 File Offset: 0x00015094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1123892, RefRangeEnd = 1123894, XrefRangeStart = 1123865, XrefRangeEnd = 1123892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveContext(InputContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_RemoveContext_Public_Void_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00016ED8 File Offset: 0x000150D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1123915, RefRangeEnd = 1123917, XrefRangeStart = 1123894, XrefRangeEnd = 1123915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isContextInStack(InputContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_isContextInStack_Private_Boolean_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00016F28 File Offset: 0x00015128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123917, XrefRangeEnd = 1123925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void pushContext(InputContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_pushContext_Private_Void_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00016F6C File Offset: 0x0001516C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123925, XrefRangeEnd = 1123932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void insertContext(InputContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_insertContext_Private_Void_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00016FB0 File Offset: 0x000151B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1123947, RefRangeEnd = 1123950, XrefRangeStart = 1123932, XrefRangeEnd = 1123947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addContext(InputContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_addContext_Private_Void_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00016FF4 File Offset: 0x000151F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1123967, RefRangeEnd = 1123968, XrefRangeStart = 1123950, XrefRangeEnd = 1123967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateCurrentContextLayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_updateCurrentContextLayer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00017028 File Offset: 0x00015228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123968, XrefRangeEnd = 1123976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void restoreLastSelectionForActiveContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_restoreLastSelectionForActiveContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001705C File Offset: 0x0001525C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1123987, RefRangeEnd = 1123991, XrefRangeStart = 1123976, XrefRangeEnd = 1123987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setInitialSelectionForActiveContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_setInitialSelectionForActiveContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00017090 File Offset: 0x00015290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123991, XrefRangeEnd = 1124000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_RefreshSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000170C4 File Offset: 0x000152C4
		[CallerCount(0)]
		public new unsafe void MarkDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr_MarkDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000170F8 File Offset: 0x000152F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124000, XrefRangeEnd = 1124021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputContextManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputContextManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputContextManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00004CD6 File Offset: 0x00002ED6
		public InputContextManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00017134 File Offset: 0x00015334
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00004CDF File Offset: 0x00002EDF
		public unsafe ulong version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContextManager.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContextManager.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0001715C File Offset: 0x0001535C
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00004CFA File Offset: 0x00002EFA
		public unsafe ulong cachedActiveContextVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContextManager.NativeFieldInfoPtr_cachedActiveContextVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContextManager.NativeFieldInfoPtr_cachedActiveContextVersion)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00017184 File Offset: 0x00015384
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00004D15 File Offset: 0x00002F15
		public unsafe InputContext nullContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContextManager.NativeFieldInfoPtr_nullContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContextManager.NativeFieldInfoPtr_nullContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000171B4 File Offset: 0x000153B4
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00004D34 File Offset: 0x00002F34
		public unsafe int currentContextLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContextManager.NativeFieldInfoPtr_currentContextLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContextManager.NativeFieldInfoPtr_currentContextLayer)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x000171DC File Offset: 0x000153DC
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00004D4F File Offset: 0x00002F4F
		public unsafe Dictionary<int, List<InputContext>> contextStacksByLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContextManager.NativeFieldInfoPtr_contextStacksByLayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<InputContext>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputContextManager.NativeFieldInfoPtr_contextStacksByLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_cachedActiveContextVersion;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_nullContext;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_currentContextLayer;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_contextStacksByLayer;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveContext_Public_get_InputContext_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_PushContext_Public_Void_InputContext_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_AddContext_Public_Void_InputContext_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_RemoveContext_Public_Void_InputContext_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_isContextInStack_Private_Boolean_InputContext_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_pushContext_Private_Void_InputContext_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_insertContext_Private_Void_InputContext_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_addContext_Private_Void_InputContext_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_updateCurrentContextLayer_Private_Void_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_restoreLastSelectionForActiveContext_Private_Void_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_setInitialSelectionForActiveContext_Private_Void_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSelection_Public_Void_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_MarkDirty_Private_Void_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
