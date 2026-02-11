using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.canis.dbg_client.behaviours
{
	// Token: 0x0200007D RID: 125
	public class MultipleBoolEvent : MonoBehaviour
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x0002C394 File Offset: 0x0002A594
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleBoolEvent()
		{
			Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.behaviours", "MultipleBoolEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr);
			MultipleBoolEvent.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, "events");
			MultipleBoolEvent.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, "condition");
			MultipleBoolEvent.NativeFieldInfoPtr_bool1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, "bool1");
			MultipleBoolEvent.NativeFieldInfoPtr_bool2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, "bool2");
			MultipleBoolEvent.NativeMethodInfoPtr_get_Bool1_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, 100664015);
			MultipleBoolEvent.NativeMethodInfoPtr_set_Bool1_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, 100664016);
			MultipleBoolEvent.NativeMethodInfoPtr_get_Bool2_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, 100664017);
			MultipleBoolEvent.NativeMethodInfoPtr_set_Bool2_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, 100664018);
			MultipleBoolEvent.NativeMethodInfoPtr_Event_SetBool1True_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, 100664019);
			MultipleBoolEvent.NativeMethodInfoPtr_Event_SetBool1False_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, 100664020);
			MultipleBoolEvent.NativeMethodInfoPtr_Event_SetBool2True_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, 100664021);
			MultipleBoolEvent.NativeMethodInfoPtr_Event_SetBool2False_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, 100664022);
			MultipleBoolEvent.NativeMethodInfoPtr_Trigger_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, 100664023);
			MultipleBoolEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr, 100664024);
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0002C4DC File Offset: 0x0002A6DC
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x0002C518 File Offset: 0x0002A718
		public unsafe bool Bool1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleBoolEvent.NativeMethodInfoPtr_get_Bool1_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501049, XrefRangeEnd = 501050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleBoolEvent.NativeMethodInfoPtr_set_Bool1_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0002C558 File Offset: 0x0002A758
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x0002C594 File Offset: 0x0002A794
		public unsafe bool Bool2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleBoolEvent.NativeMethodInfoPtr_get_Bool2_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501050, XrefRangeEnd = 501051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleBoolEvent.NativeMethodInfoPtr_set_Bool2_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0002C5D4 File Offset: 0x0002A7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501051, XrefRangeEnd = 501054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBool1True()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleBoolEvent.NativeMethodInfoPtr_Event_SetBool1True_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0002C608 File Offset: 0x0002A808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501054, XrefRangeEnd = 501056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBool1False()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleBoolEvent.NativeMethodInfoPtr_Event_SetBool1False_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0002C63C File Offset: 0x0002A83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501056, XrefRangeEnd = 501057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBool2True()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleBoolEvent.NativeMethodInfoPtr_Event_SetBool2True_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0002C670 File Offset: 0x0002A870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501057, XrefRangeEnd = 501058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetBool2False()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleBoolEvent.NativeMethodInfoPtr_Event_SetBool2False_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0002C6A4 File Offset: 0x0002A8A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 501069, RefRangeEnd = 501073, XrefRangeStart = 501058, XrefRangeEnd = 501069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleBoolEvent.NativeMethodInfoPtr_Trigger_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0002C6D8 File Offset: 0x0002A8D8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleBoolEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleBoolEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleBoolEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00004221 File Offset: 0x00002421
		public MultipleBoolEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0002C714 File Offset: 0x0002A914
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x0000422A File Offset: 0x0000242A
		public unsafe BoolUnityEvents events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleBoolEvent.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleBoolEvent.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0002C744 File Offset: 0x0002A944
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00004249 File Offset: 0x00002449
		public unsafe MultipleBoolEvent.BoolConditions condition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleBoolEvent.NativeFieldInfoPtr_condition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleBoolEvent.NativeFieldInfoPtr_condition)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0002C76C File Offset: 0x0002A96C
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00004264 File Offset: 0x00002464
		public unsafe bool bool1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleBoolEvent.NativeFieldInfoPtr_bool1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleBoolEvent.NativeFieldInfoPtr_bool1)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0002C794 File Offset: 0x0002A994
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x0000427F File Offset: 0x0000247F
		public unsafe bool bool2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleBoolEvent.NativeFieldInfoPtr_bool2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleBoolEvent.NativeFieldInfoPtr_bool2)) = value;
			}
		}

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_condition;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_bool1;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_bool2;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_get_Bool1_Public_get_Boolean_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_set_Bool1_Public_set_Void_Boolean_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_get_Bool2_Public_get_Boolean_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_set_Bool2_Public_set_Void_Boolean_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBool1True_Public_Void_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBool1False_Public_Void_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBool2True_Public_Void_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetBool2False_Public_Void_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Private_Void_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002FB RID: 763
		[Serializable]
		public enum BoolConditions
		{
			// Token: 0x0400169E RID: 5790
			AND,
			// Token: 0x0400169F RID: 5791
			OR,
			// Token: 0x040016A0 RID: 5792
			XOR
		}
	}
}
