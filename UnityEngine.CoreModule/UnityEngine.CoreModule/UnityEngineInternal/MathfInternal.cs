using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngineInternal
{
	// Token: 0x02000005 RID: 5
	[StructLayout(2)]
	public struct MathfInternal
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00016A88 File Offset: 0x00014C88
		// Note: this type is marked as 'beforefieldinit'.
		static MathfInternal()
		{
			Il2CppClassPointerStore<MathfInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", "MathfInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr);
			MathfInternal.NativeFieldInfoPtr_FloatMinNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, "FloatMinNormal");
			MathfInternal.NativeFieldInfoPtr_FloatMinDenormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, "FloatMinDenormal");
			MathfInternal.NativeFieldInfoPtr_IsFlushToZeroEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, "IsFlushToZeroEnabled");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002116 File Offset: 0x00000316
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, ref this));
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00016AF4 File Offset: 0x00014CF4
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002128 File Offset: 0x00000328
		public unsafe static float FloatMinNormal
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathfInternal.NativeFieldInfoPtr_FloatMinNormal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathfInternal.NativeFieldInfoPtr_FloatMinNormal, (void*)(&value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00016B10 File Offset: 0x00014D10
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002136 File Offset: 0x00000336
		public unsafe static float FloatMinDenormal
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathfInternal.NativeFieldInfoPtr_FloatMinDenormal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathfInternal.NativeFieldInfoPtr_FloatMinDenormal, (void*)(&value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00016B2C File Offset: 0x00014D2C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002144 File Offset: 0x00000344
		public unsafe static bool IsFlushToZeroEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MathfInternal.NativeFieldInfoPtr_IsFlushToZeroEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathfInternal.NativeFieldInfoPtr_IsFlushToZeroEnabled, (void*)(&value));
			}
		}

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_FloatMinNormal;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_FloatMinDenormal;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_IsFlushToZeroEnabled;
	}
}
