using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.canis.dbg_client.behaviours
{
	// Token: 0x0200007C RID: 124
	public class EventsForMouseWithinCollider : MonoBehaviour
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x0002C140 File Offset: 0x0002A340
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForMouseWithinCollider()
		{
			Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.behaviours", "EventsForMouseWithinCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr);
			EventsForMouseWithinCollider.NativeFieldInfoPtr_eventsForMouseover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr, "eventsForMouseover");
			EventsForMouseWithinCollider.NativeFieldInfoPtr_mouseoverBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr, "mouseoverBounds");
			EventsForMouseWithinCollider.NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr, "mainCamera");
			EventsForMouseWithinCollider.NativeFieldInfoPtr_cachedMousePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr, "cachedMousePos");
			EventsForMouseWithinCollider.NativeFieldInfoPtr_frameSkipCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr, "frameSkipCounter");
			EventsForMouseWithinCollider.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr, 100664012);
			EventsForMouseWithinCollider.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr, 100664013);
			EventsForMouseWithinCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr, 100664014);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0002C210 File Offset: 0x0002A410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501032, XrefRangeEnd = 501039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseWithinCollider.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0002C244 File Offset: 0x0002A444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501039, XrefRangeEnd = 501041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseWithinCollider.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0002C278 File Offset: 0x0002A478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501041, XrefRangeEnd = 501049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForMouseWithinCollider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForMouseWithinCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForMouseWithinCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00004185 File Offset: 0x00002385
		public EventsForMouseWithinCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0002C2B4 File Offset: 0x0002A4B4
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x0000418E File Offset: 0x0000238E
		public unsafe BoolUnityEvents eventsForMouseover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseWithinCollider.NativeFieldInfoPtr_eventsForMouseover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseWithinCollider.NativeFieldInfoPtr_eventsForMouseover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0002C2E4 File Offset: 0x0002A4E4
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x000041AD File Offset: 0x000023AD
		public unsafe Collider mouseoverBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseWithinCollider.NativeFieldInfoPtr_mouseoverBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseWithinCollider.NativeFieldInfoPtr_mouseoverBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0002C314 File Offset: 0x0002A514
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x000041CC File Offset: 0x000023CC
		public unsafe Camera mainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseWithinCollider.NativeFieldInfoPtr_mainCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseWithinCollider.NativeFieldInfoPtr_mainCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0002C344 File Offset: 0x0002A544
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x000041EB File Offset: 0x000023EB
		public unsafe Vector3 cachedMousePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseWithinCollider.NativeFieldInfoPtr_cachedMousePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseWithinCollider.NativeFieldInfoPtr_cachedMousePos)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0002C36C File Offset: 0x0002A56C
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00004206 File Offset: 0x00002406
		public unsafe int frameSkipCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseWithinCollider.NativeFieldInfoPtr_frameSkipCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForMouseWithinCollider.NativeFieldInfoPtr_frameSkipCounter)) = value;
			}
		}

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr_eventsForMouseover;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr_mouseoverBounds;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_mainCamera;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr_cachedMousePos;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_frameSkipCounter;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
