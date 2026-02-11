using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200025A RID: 602
	[Serializable]
	public sealed class RSAParameters : ValueType
	{
		// Token: 0x060026FE RID: 9982 RVA: 0x000D4AD4 File Offset: 0x000D2CD4
		// Note: this type is marked as 'beforefieldinit'.
		static RSAParameters()
		{
			Il2CppClassPointerStore<RSAParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr);
			RSAParameters.NativeFieldInfoPtr_Exponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "Exponent");
			RSAParameters.NativeFieldInfoPtr_Modulus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "Modulus");
			RSAParameters.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "P");
			RSAParameters.NativeFieldInfoPtr_Q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "Q");
			RSAParameters.NativeFieldInfoPtr_DP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "DP");
			RSAParameters.NativeFieldInfoPtr_DQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "DQ");
			RSAParameters.NativeFieldInfoPtr_InverseQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "InverseQ");
			RSAParameters.NativeFieldInfoPtr_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "D");
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x0000CB63 File Offset: 0x0000AD63
		public RSAParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		public RSAParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr))
		{
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000D4BA4 File Offset: 0x000D2DA4
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x0000CB7E File Offset: 0x0000AD7E
		public unsafe Il2CppStructArray<byte> Exponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Exponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Exponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x000D4BD4 File Offset: 0x000D2DD4
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x0000CB9D File Offset: 0x0000AD9D
		public unsafe Il2CppStructArray<byte> Modulus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Modulus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Modulus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x000D4C04 File Offset: 0x000D2E04
		// (set) Token: 0x06002706 RID: 9990 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		public unsafe Il2CppStructArray<byte> P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_P);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_P), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x000D4C34 File Offset: 0x000D2E34
		// (set) Token: 0x06002708 RID: 9992 RVA: 0x0000CBDB File Offset: 0x0000ADDB
		public unsafe Il2CppStructArray<byte> Q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x000D4C64 File Offset: 0x000D2E64
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x0000CBFA File Offset: 0x0000ADFA
		public unsafe Il2CppStructArray<byte> DP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x000D4C94 File Offset: 0x000D2E94
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x0000CC19 File Offset: 0x0000AE19
		public unsafe Il2CppStructArray<byte> DQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x000D4CC4 File Offset: 0x000D2EC4
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x0000CC38 File Offset: 0x0000AE38
		public unsafe Il2CppStructArray<byte> InverseQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_InverseQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_InverseQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x000D4CF4 File Offset: 0x000D2EF4
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x0000CC57 File Offset: 0x0000AE57
		public unsafe Il2CppStructArray<byte> D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021A2 RID: 8610
		private static readonly IntPtr NativeFieldInfoPtr_Exponent;

		// Token: 0x040021A3 RID: 8611
		private static readonly IntPtr NativeFieldInfoPtr_Modulus;

		// Token: 0x040021A4 RID: 8612
		private static readonly IntPtr NativeFieldInfoPtr_P;

		// Token: 0x040021A5 RID: 8613
		private static readonly IntPtr NativeFieldInfoPtr_Q;

		// Token: 0x040021A6 RID: 8614
		private static readonly IntPtr NativeFieldInfoPtr_DP;

		// Token: 0x040021A7 RID: 8615
		private static readonly IntPtr NativeFieldInfoPtr_DQ;

		// Token: 0x040021A8 RID: 8616
		private static readonly IntPtr NativeFieldInfoPtr_InverseQ;

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeFieldInfoPtr_D;
	}
}
