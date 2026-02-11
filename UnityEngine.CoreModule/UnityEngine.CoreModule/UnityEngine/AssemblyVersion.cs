using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000133 RID: 307
	[StructLayout(2)]
	public struct AssemblyVersion
	{
		// Token: 0x060017CD RID: 6093 RVA: 0x0007072C File Offset: 0x0006E92C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyVersion()
		{
			Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AssemblyVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr);
			AssemblyVersion.NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "major");
			AssemblyVersion.NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "minor");
			AssemblyVersion.NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "build");
			AssemblyVersion.NativeFieldInfoPtr_revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "revision");
			AssemblyVersion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100666543);
			AssemblyVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100666544);
			AssemblyVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100666545);
			AssemblyVersion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100666546);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x000707FC File Offset: 0x0006E9FC
		[CallerCount(0)]
		public unsafe static bool operator ==(AssemblyVersion lhs, AssemblyVersion rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00070848 File Offset: 0x0006EA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 661837, XrefRangeEnd = 661860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00070874 File Offset: 0x0006EA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 661860, XrefRangeEnd = 661863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x000708B8 File Offset: 0x0006EAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 661863, XrefRangeEnd = 661869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00009732 File Offset: 0x00007932
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, ref this));
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x000708E8 File Offset: 0x0006EAE8
		public static bool operator !=(AssemblyVersion lhs, AssemblyVersion rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00070904 File Offset: 0x0006EB04
		public static bool operator <(AssemblyVersion lhs, AssemblyVersion rhs)
		{
			bool flag = lhs.major != rhs.major;
			bool flag2;
			if (flag)
			{
				flag2 = lhs.major < rhs.major;
			}
			else
			{
				bool flag3 = lhs.minor != rhs.minor;
				if (flag3)
				{
					flag2 = lhs.minor < rhs.minor;
				}
				else
				{
					bool flag4 = lhs.build != rhs.build;
					if (flag4)
					{
						flag2 = lhs.build < rhs.build;
					}
					else
					{
						bool flag5 = lhs.revision != rhs.revision;
						flag2 = flag5 && lhs.revision < rhs.revision;
					}
				}
			}
			return flag2;
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x000709B4 File Offset: 0x0006EBB4
		public static bool operator >(AssemblyVersion lhs, AssemblyVersion rhs)
		{
			bool flag = lhs.major != rhs.major;
			bool flag2;
			if (flag)
			{
				flag2 = lhs.major > rhs.major;
			}
			else
			{
				bool flag3 = lhs.minor != rhs.minor;
				if (flag3)
				{
					flag2 = lhs.minor > rhs.minor;
				}
				else
				{
					bool flag4 = lhs.build != rhs.build;
					if (flag4)
					{
						flag2 = lhs.build > rhs.build;
					}
					else
					{
						bool flag5 = lhs.revision != rhs.revision;
						flag2 = flag5 && lhs.revision > rhs.revision;
					}
				}
			}
			return flag2;
		}

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeFieldInfoPtr_major;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeFieldInfoPtr_minor;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeFieldInfoPtr_build;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeFieldInfoPtr_revision;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400156B RID: 5483
		[FieldOffset(0)]
		public ushort major;

		// Token: 0x0400156C RID: 5484
		[FieldOffset(2)]
		public ushort minor;

		// Token: 0x0400156D RID: 5485
		[FieldOffset(4)]
		public ushort build;

		// Token: 0x0400156E RID: 5486
		[FieldOffset(6)]
		public ushort revision;
	}
}
