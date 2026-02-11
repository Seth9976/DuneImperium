using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000006 RID: 6
	public class ClickCounter : MonoBehaviour
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000034A8 File Offset: 0x000016A8
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCounter()
		{
			Il2CppClassPointerStore<ClickCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "ClickCounter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr);
			ClickCounter.NativeFieldInfoPtr_currentClicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, "currentClicks");
			ClickCounter.NativeFieldInfoPtr_increaseProbabilityAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, "increaseProbabilityAt");
			ClickCounter.NativeFieldInfoPtr_randomizedParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, "randomizedParameterName");
			ClickCounter.NativeFieldInfoPtr_clickParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, "clickParameterName");
			ClickCounter.NativeFieldInfoPtr_percentageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, "percentageIncrease");
			ClickCounter.NativeFieldInfoPtr_beginningPercentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, "beginningPercentValue");
			ClickCounter.NativeFieldInfoPtr_randomKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, "randomKey");
			ClickCounter.NativeFieldInfoPtr_clickKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, "clickKey");
			ClickCounter.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, "animator");
			ClickCounter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, 100663324);
			ClickCounter.NativeMethodInfoPtr_AddToClickCounter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, 100663325);
			ClickCounter.NativeMethodInfoPtr_SetClickCounterTo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, 100663326);
			ClickCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr, 100663327);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000035DC File Offset: 0x000017DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263202, XrefRangeEnd = 1263208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickCounter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003610 File Offset: 0x00001810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263208, XrefRangeEnd = 1263212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToClickCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickCounter.NativeMethodInfoPtr_AddToClickCounter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003644 File Offset: 0x00001844
		[CallerCount(0)]
		public unsafe void SetClickCounterTo(int resetTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resetTo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickCounter.NativeMethodInfoPtr_SetClickCounterTo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003684 File Offset: 0x00001884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263212, XrefRangeEnd = 1263221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCounter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickCounter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000216B File Offset: 0x0000036B
		public ClickCounter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000036C0 File Offset: 0x000018C0
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002174 File Offset: 0x00000374
		public unsafe int currentClicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_currentClicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_currentClicks)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000036E8 File Offset: 0x000018E8
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000218F File Offset: 0x0000038F
		public unsafe int increaseProbabilityAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_increaseProbabilityAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_increaseProbabilityAt)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003710 File Offset: 0x00001910
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000021AA File Offset: 0x000003AA
		public unsafe string randomizedParameterName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_randomizedParameterName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_randomizedParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003738 File Offset: 0x00001938
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000021C9 File Offset: 0x000003C9
		public unsafe string clickParameterName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_clickParameterName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_clickParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003760 File Offset: 0x00001960
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021E8 File Offset: 0x000003E8
		public unsafe float percentageIncrease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_percentageIncrease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_percentageIncrease)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003788 File Offset: 0x00001988
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002203 File Offset: 0x00000403
		public unsafe float beginningPercentValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_beginningPercentValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_beginningPercentValue)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000037B0 File Offset: 0x000019B0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000221E File Offset: 0x0000041E
		public unsafe int randomKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_randomKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_randomKey)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000037D8 File Offset: 0x000019D8
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002239 File Offset: 0x00000439
		public unsafe int clickKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_clickKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_clickKey)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003800 File Offset: 0x00001A00
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002254 File Offset: 0x00000454
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickCounter.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_currentClicks;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_increaseProbabilityAt;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_randomizedParameterName;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_clickParameterName;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_percentageIncrease;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_beginningPercentValue;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_randomKey;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_clickKey;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_AddToClickCounter_Public_Void_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_SetClickCounterTo_Public_Void_Int32_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
