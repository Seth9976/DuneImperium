using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.direction
{
	// Token: 0x020001A3 RID: 419
	[StructLayout(2)]
	public struct Direction2
	{
		// Token: 0x060017FE RID: 6142 RVA: 0x00073F10 File Offset: 0x00072110
		// Note: this type is marked as 'beforefieldinit'.
		static Direction2()
		{
			Il2CppClassPointerStore<Direction2>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.direction", "Direction2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Direction2>.NativeClassPtr);
			Direction2.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Direction2>.NativeClassPtr, "X");
			Direction2.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Direction2>.NativeClassPtr, "Y");
			Direction2.NativeMethodInfoPtr_Equals_Public_Boolean_Direction2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Direction2>.NativeClassPtr, 100667106);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00073F7C File Offset: 0x0007217C
		[CallerCount(0)]
		public unsafe bool Equals(Direction2 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Direction2.NativeMethodInfoPtr_Equals_Public_Boolean_Direction2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0000A88A File Offset: 0x00008A8A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Direction2>.NativeClassPtr, ref this));
		}

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Direction2_0;

		// Token: 0x040010FE RID: 4350
		[FieldOffset(0)]
		public Direction X;

		// Token: 0x040010FF RID: 4351
		[FieldOffset(4)]
		public Direction Y;

		// Token: 0x0200034C RID: 844
		[Serializable]
		public class Serializable : Object
		{
			// Token: 0x060026DE RID: 9950 RVA: 0x000A5648 File Offset: 0x000A3848
			// Note: this type is marked as 'beforefieldinit'.
			static Serializable()
			{
				Il2CppClassPointerStore<Direction2.Serializable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Direction2>.NativeClassPtr, "Serializable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Direction2.Serializable>.NativeClassPtr);
				Direction2.Serializable.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Direction2.Serializable>.NativeClassPtr, "X");
				Direction2.Serializable.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Direction2.Serializable>.NativeClassPtr, "Y");
				Direction2.Serializable.NativeMethodInfoPtr_op_Implicit_Public_Static_Direction2_Serializable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Direction2.Serializable>.NativeClassPtr, 100667107);
				Direction2.Serializable.NativeMethodInfoPtr_op_Implicit_Public_Static_Serializable_Direction2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Direction2.Serializable>.NativeClassPtr, 100667108);
				Direction2.Serializable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Direction2.Serializable>.NativeClassPtr, 100667109);
			}

			// Token: 0x060026DF RID: 9951 RVA: 0x000A56D8 File Offset: 0x000A38D8
			[CallerCount(0)]
			public unsafe static implicit operator Direction2(Direction2.Serializable other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Direction2.Serializable.NativeMethodInfoPtr_op_Implicit_Public_Static_Direction2_Serializable_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060026E0 RID: 9952 RVA: 0x000A571C File Offset: 0x000A391C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879722, XrefRangeEnd = 879726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator Direction2.Serializable(Direction2 other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref other;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Direction2.Serializable.NativeMethodInfoPtr_op_Implicit_Public_Static_Serializable_Direction2_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Direction2.Serializable>(intPtr3) : null;
				}
			}

			// Token: 0x060026E1 RID: 9953 RVA: 0x000A575C File Offset: 0x000A395C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Serializable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Direction2.Serializable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Direction2.Serializable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026E2 RID: 9954 RVA: 0x00011B06 File Offset: 0x0000FD06
			public Serializable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B02 RID: 2818
			// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000A5798 File Offset: 0x000A3998
			// (set) Token: 0x060026E4 RID: 9956 RVA: 0x00011B0F File Offset: 0x0000FD0F
			public unsafe Direction X
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Direction2.Serializable.NativeFieldInfoPtr_X);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Direction2.Serializable.NativeFieldInfoPtr_X)) = value;
				}
			}

			// Token: 0x17000B03 RID: 2819
			// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000A57C0 File Offset: 0x000A39C0
			// (set) Token: 0x060026E6 RID: 9958 RVA: 0x00011B2A File Offset: 0x0000FD2A
			public unsafe Direction Y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Direction2.Serializable.NativeFieldInfoPtr_Y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Direction2.Serializable.NativeFieldInfoPtr_Y)) = value;
				}
			}

			// Token: 0x04001A6B RID: 6763
			private static readonly IntPtr NativeFieldInfoPtr_X;

			// Token: 0x04001A6C RID: 6764
			private static readonly IntPtr NativeFieldInfoPtr_Y;

			// Token: 0x04001A6D RID: 6765
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Direction2_Serializable_0;

			// Token: 0x04001A6E RID: 6766
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Serializable_Direction2_0;

			// Token: 0x04001A6F RID: 6767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
