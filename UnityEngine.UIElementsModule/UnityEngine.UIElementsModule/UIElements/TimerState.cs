using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000175 RID: 373
	[StructLayout(2)]
	public struct TimerState
	{
		// Token: 0x06001BAE RID: 7086 RVA: 0x0007E8CC File Offset: 0x0007CACC
		// Note: this type is marked as 'beforefieldinit'.
		static TimerState()
		{
			Il2CppClassPointerStore<TimerState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TimerState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerState>.NativeClassPtr);
			TimerState.NativeFieldInfoPtr__start_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerState>.NativeClassPtr, "<start>k__BackingField");
			TimerState.NativeFieldInfoPtr__now_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerState>.NativeClassPtr, "<now>k__BackingField");
			TimerState.NativeMethodInfoPtr_get_start_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerState>.NativeClassPtr, 100667318);
			TimerState.NativeMethodInfoPtr_set_start_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerState>.NativeClassPtr, 100667319);
			TimerState.NativeMethodInfoPtr_get_now_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerState>.NativeClassPtr, 100667320);
			TimerState.NativeMethodInfoPtr_set_now_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerState>.NativeClassPtr, 100667321);
			TimerState.NativeMethodInfoPtr_get_deltaTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerState>.NativeClassPtr, 100667322);
			TimerState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerState>.NativeClassPtr, 100667323);
			TimerState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerState>.NativeClassPtr, 100667324);
			TimerState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerState>.NativeClassPtr, 100667325);
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x0007E9C4 File Offset: 0x0007CBC4
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x0007E9F4 File Offset: 0x0007CBF4
		public unsafe long start
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerState.NativeMethodInfoPtr_get_start_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerState.NativeMethodInfoPtr_set_start_Public_set_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x0007EA28 File Offset: 0x0007CC28
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0007EA58 File Offset: 0x0007CC58
		public unsafe long now
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerState.NativeMethodInfoPtr_get_now_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerState.NativeMethodInfoPtr_set_now_Public_set_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x0007EA8C File Offset: 0x0007CC8C
		public unsafe long deltaTime
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerState.NativeMethodInfoPtr_get_deltaTime_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0007EABC File Offset: 0x0007CCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323382, XrefRangeEnd = 323385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0007EB00 File Offset: 0x0007CD00
		[CallerCount(0)]
		public unsafe bool Equals(TimerState other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimerState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0007EB40 File Offset: 0x0007CD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323385, XrefRangeEnd = 323388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0000C87F File Offset: 0x0000AA7F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimerState>.NativeClassPtr, ref this));
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0007EB70 File Offset: 0x0007CD70
		public static bool operator ==(TimerState state1, TimerState state2)
		{
			return state1.Equals(state2);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0007EB8C File Offset: 0x0007CD8C
		public static bool operator !=(TimerState state1, TimerState state2)
		{
			return !(state1 == state2);
		}

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr__start_k__BackingField;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr__now_k__BackingField;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_get_Int64_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_set_start_Public_set_Void_Int64_0;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr_get_now_Public_get_Int64_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_set_now_Public_set_Void_Int64_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_get_Int64_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimerState_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001327 RID: 4903
		[FieldOffset(0)]
		public long _start_k__BackingField;

		// Token: 0x04001328 RID: 4904
		[FieldOffset(8)]
		public long _now_k__BackingField;
	}
}
