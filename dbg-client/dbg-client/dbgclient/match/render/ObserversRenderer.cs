using System;
using boardgames.match.behaviours;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.Events;

namespace dbgclient.match.render
{
	// Token: 0x020000A8 RID: 168
	public class ObserversRenderer : VersionedView<ObserversProvider>
	{
		// Token: 0x06000697 RID: 1687 RVA: 0x000327A8 File Offset: 0x000309A8
		// Note: this type is marked as 'beforefieldinit'.
		static ObserversRenderer()
		{
			Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.match.render", "ObserversRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr);
			ObserversRenderer.NativeFieldInfoPtr_countText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, "countText");
			ObserversRenderer.NativeFieldInfoPtr_textFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, "textFormat");
			ObserversRenderer.NativeFieldInfoPtr_onAnyObservers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, "onAnyObservers");
			ObserversRenderer.NativeFieldInfoPtr_onObserverJoined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, "onObserverJoined");
			ObserversRenderer.NativeFieldInfoPtr_onObserverLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, "onObserverLeft");
			ObserversRenderer.NativeFieldInfoPtr_observerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, "observerCount");
			ObserversRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, 100664343);
			ObserversRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, 100664344);
			ObserversRenderer.NativeMethodInfoPtr_NoObservers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, 100664345);
			ObserversRenderer.NativeMethodInfoPtr_Event_UpdateCountText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, 100664346);
			ObserversRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr, 100664347);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000328B4 File Offset: 0x00030AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503677, XrefRangeEnd = 503684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserversRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000328F0 File Offset: 0x00030AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503684, XrefRangeEnd = 503695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserversRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0003292C File Offset: 0x00030B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503695, XrefRangeEnd = 503697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoObservers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversRenderer.NativeMethodInfoPtr_NoObservers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00032960 File Offset: 0x00030B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503697, XrefRangeEnd = 503701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UpdateCountText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversRenderer.NativeMethodInfoPtr_Event_UpdateCountText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00032994 File Offset: 0x00030B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503701, XrefRangeEnd = 503708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserversRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserversRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00004FA4 File Offset: 0x000031A4
		public ObserversRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x000329D0 File Offset: 0x00030BD0
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00004FAD File Offset: 0x000031AD
		public unsafe TMP_Text countText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_countText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_countText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00032A00 File Offset: 0x00030C00
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00004FCC File Offset: 0x000031CC
		public unsafe string textFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_textFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_textFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00032A28 File Offset: 0x00030C28
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00004FEB File Offset: 0x000031EB
		public unsafe BoolUnityEvents onAnyObservers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_onAnyObservers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_onAnyObservers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00032A58 File Offset: 0x00030C58
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x0000500A File Offset: 0x0000320A
		public unsafe UnityEvent onObserverJoined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_onObserverJoined);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_onObserverJoined), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00032A88 File Offset: 0x00030C88
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00005029 File Offset: 0x00003229
		public unsafe UnityEvent onObserverLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_onObserverLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_onObserverLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00032AB8 File Offset: 0x00030CB8
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00005048 File Offset: 0x00003248
		public unsafe ulong observerCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_observerCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversRenderer.NativeFieldInfoPtr_observerCount)) = value;
			}
		}

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_countText;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_textFormat;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_onAnyObservers;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_onObserverJoined;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr_onObserverLeft;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr_observerCount;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_NoObservers_Private_Void_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_Event_UpdateCountText_Public_Void_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
