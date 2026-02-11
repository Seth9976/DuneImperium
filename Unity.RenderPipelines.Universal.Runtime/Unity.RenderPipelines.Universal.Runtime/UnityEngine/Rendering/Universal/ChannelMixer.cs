using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200008E RID: 142
	[Serializable]
	public sealed class ChannelMixer : VolumeComponent
	{
		// Token: 0x06000C8B RID: 3211 RVA: 0x00041A18 File Offset: 0x0003FC18
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelMixer()
		{
			Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ChannelMixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr);
			ChannelMixer.NativeFieldInfoPtr_redOutRedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, "redOutRedIn");
			ChannelMixer.NativeFieldInfoPtr_redOutGreenIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, "redOutGreenIn");
			ChannelMixer.NativeFieldInfoPtr_redOutBlueIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, "redOutBlueIn");
			ChannelMixer.NativeFieldInfoPtr_greenOutRedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, "greenOutRedIn");
			ChannelMixer.NativeFieldInfoPtr_greenOutGreenIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, "greenOutGreenIn");
			ChannelMixer.NativeFieldInfoPtr_greenOutBlueIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, "greenOutBlueIn");
			ChannelMixer.NativeFieldInfoPtr_blueOutRedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, "blueOutRedIn");
			ChannelMixer.NativeFieldInfoPtr_blueOutGreenIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, "blueOutGreenIn");
			ChannelMixer.NativeFieldInfoPtr_blueOutBlueIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, "blueOutBlueIn");
			ChannelMixer.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, 100665001);
			ChannelMixer.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, 100665002);
			ChannelMixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, 100665003);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00041B38 File Offset: 0x0003FD38
		[CallerCount(0)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMixer.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00041B74 File Offset: 0x0003FD74
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMixer.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00041BB0 File Offset: 0x0003FDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611887, XrefRangeEnd = 611925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelMixer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelMixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00007AD5 File Offset: 0x00005CD5
		public ChannelMixer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00041BEC File Offset: 0x0003FDEC
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00007ADE File Offset: 0x00005CDE
		public unsafe ClampedFloatParameter redOutRedIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redOutRedIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redOutRedIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00041C1C File Offset: 0x0003FE1C
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00007AFD File Offset: 0x00005CFD
		public unsafe ClampedFloatParameter redOutGreenIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redOutGreenIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redOutGreenIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00041C4C File Offset: 0x0003FE4C
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00007B1C File Offset: 0x00005D1C
		public unsafe ClampedFloatParameter redOutBlueIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redOutBlueIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redOutBlueIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00041C7C File Offset: 0x0003FE7C
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00007B3B File Offset: 0x00005D3B
		public unsafe ClampedFloatParameter greenOutRedIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenOutRedIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenOutRedIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00041CAC File Offset: 0x0003FEAC
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00007B5A File Offset: 0x00005D5A
		public unsafe ClampedFloatParameter greenOutGreenIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenOutGreenIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenOutGreenIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00041CDC File Offset: 0x0003FEDC
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x00007B79 File Offset: 0x00005D79
		public unsafe ClampedFloatParameter greenOutBlueIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenOutBlueIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenOutBlueIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00041D0C File Offset: 0x0003FF0C
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x00007B98 File Offset: 0x00005D98
		public unsafe ClampedFloatParameter blueOutRedIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueOutRedIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueOutRedIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00041D3C File Offset: 0x0003FF3C
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00007BB7 File Offset: 0x00005DB7
		public unsafe ClampedFloatParameter blueOutGreenIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueOutGreenIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueOutGreenIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00041D6C File Offset: 0x0003FF6C
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00007BD6 File Offset: 0x00005DD6
		public unsafe ClampedFloatParameter blueOutBlueIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueOutBlueIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueOutBlueIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr_redOutRedIn;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr_redOutGreenIn;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr_redOutBlueIn;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr_greenOutRedIn;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_greenOutGreenIn;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr_greenOutBlueIn;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeFieldInfoPtr_blueOutRedIn;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeFieldInfoPtr_blueOutGreenIn;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeFieldInfoPtr_blueOutBlueIn;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
