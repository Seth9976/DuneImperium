using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000241 RID: 577
	[Serializable]
	public sealed class DSAParameters : ValueType
	{
		// Token: 0x060025CB RID: 9675 RVA: 0x000D05DC File Offset: 0x000CE7DC
		// Note: this type is marked as 'beforefieldinit'.
		static DSAParameters()
		{
			Il2CppClassPointerStore<DSAParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSAParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr);
			DSAParameters.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "P");
			DSAParameters.NativeFieldInfoPtr_Q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Q");
			DSAParameters.NativeFieldInfoPtr_G = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "G");
			DSAParameters.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Y");
			DSAParameters.NativeFieldInfoPtr_J = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "J");
			DSAParameters.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "X");
			DSAParameters.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Seed");
			DSAParameters.NativeFieldInfoPtr_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Counter");
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x0000C381 File Offset: 0x0000A581
		public DSAParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x0000C38A File Offset: 0x0000A58A
		public DSAParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr))
		{
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x000D06AC File Offset: 0x000CE8AC
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x0000C39C File Offset: 0x0000A59C
		public unsafe Il2CppStructArray<byte> P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_P);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_P), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x000D06DC File Offset: 0x000CE8DC
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x0000C3BB File Offset: 0x0000A5BB
		public unsafe Il2CppStructArray<byte> Q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x000D070C File Offset: 0x000CE90C
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x0000C3DA File Offset: 0x0000A5DA
		public unsafe Il2CppStructArray<byte> G
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_G);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_G), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x000D073C File Offset: 0x000CE93C
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x0000C3F9 File Offset: 0x0000A5F9
		public unsafe Il2CppStructArray<byte> Y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Y);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Y), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x000D076C File Offset: 0x000CE96C
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x0000C418 File Offset: 0x0000A618
		public unsafe Il2CppStructArray<byte> J
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_J);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_J), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x000D079C File Offset: 0x000CE99C
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x0000C437 File Offset: 0x0000A637
		public unsafe Il2CppStructArray<byte> X
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_X);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_X), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000D07CC File Offset: 0x000CE9CC
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x0000C456 File Offset: 0x0000A656
		public unsafe Il2CppStructArray<byte> Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x000D07FC File Offset: 0x000CE9FC
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x0000C475 File Offset: 0x0000A675
		public unsafe int Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Counter)) = value;
			}
		}

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeFieldInfoPtr_P;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeFieldInfoPtr_Q;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeFieldInfoPtr_G;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeFieldInfoPtr_J;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeFieldInfoPtr_Counter;
	}
}
