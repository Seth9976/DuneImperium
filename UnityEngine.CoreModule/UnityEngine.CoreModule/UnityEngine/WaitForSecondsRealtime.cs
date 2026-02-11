using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200015D RID: 349
	public class WaitForSecondsRealtime : CustomYieldInstruction
	{
		// Token: 0x060019EA RID: 6634 RVA: 0x0007A024 File Offset: 0x00078224
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForSecondsRealtime()
		{
			Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForSecondsRealtime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr);
			WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, "<waitTime>k__BackingField");
			WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, "m_WaitUntilTime");
			WaitForSecondsRealtime.NativeMethodInfoPtr_get_waitTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100666908);
			WaitForSecondsRealtime.NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100666909);
			WaitForSecondsRealtime.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100666910);
			WaitForSecondsRealtime.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100666911);
			WaitForSecondsRealtime.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100666912);
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x0007A0E0 File Offset: 0x000782E0
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x0007A11C File Offset: 0x0007831C
		public unsafe float waitTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr_get_waitTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x0007A15C File Offset: 0x0007835C
		public unsafe override bool keepWaiting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673071, XrefRangeEnd = 673075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForSecondsRealtime.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0007A1A4 File Offset: 0x000783A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 673076, RefRangeEnd = 673080, XrefRangeStart = 673075, XrefRangeEnd = 673076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForSecondsRealtime(float time)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0007A1EC File Offset: 0x000783EC
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForSecondsRealtime.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00009FC5 File Offset: 0x000081C5
		public WaitForSecondsRealtime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x0007A228 File Offset: 0x00078428
		// (set) Token: 0x060019F2 RID: 6642 RVA: 0x00009FCE File Offset: 0x000081CE
		public unsafe float _waitTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField)) = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0007A250 File Offset: 0x00078450
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x00009FE9 File Offset: 0x000081E9
		public unsafe float m_WaitUntilTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime)) = value;
			}
		}

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeFieldInfoPtr__waitTime_k__BackingField;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitUntilTime;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeMethodInfoPtr_get_waitTime_Public_get_Single_0;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
	}
}
