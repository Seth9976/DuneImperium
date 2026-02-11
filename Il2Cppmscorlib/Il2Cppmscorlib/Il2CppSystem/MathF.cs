using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000C1 RID: 193
	public static class MathF : Object
	{
		// Token: 0x06000CBA RID: 3258 RVA: 0x00060C60 File Offset: 0x0005EE60
		// Note: this type is marked as 'beforefieldinit'.
		static MathF()
		{
			Il2CppClassPointerStore<MathF>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MathF");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathF>.NativeClassPtr);
			MathF.NativeFieldInfoPtr_roundPower10Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathF>.NativeClassPtr, "roundPower10Single");
			MathF.NativeFieldInfoPtr_singleRoundLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathF>.NativeClassPtr, "singleRoundLimit");
			MathF.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathF>.NativeClassPtr, 100665529);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00060CCC File Offset: 0x0005EECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311062, XrefRangeEnd = 1311065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Abs(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathF.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x000051D5 File Offset: 0x000033D5
		public MathF(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00060D0C File Offset: 0x0005EF0C
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x000051DE File Offset: 0x000033DE
		public unsafe static Il2CppStructArray<float> roundPower10Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MathF.NativeFieldInfoPtr_roundPower10Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathF.NativeFieldInfoPtr_roundPower10Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00060D34 File Offset: 0x0005EF34
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x000051F0 File Offset: 0x000033F0
		public unsafe static float singleRoundLimit
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathF.NativeFieldInfoPtr_singleRoundLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathF.NativeFieldInfoPtr_singleRoundLimit, (void*)(&value));
			}
		}

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeFieldInfoPtr_roundPower10Single;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr_singleRoundLimit;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;
	}
}
