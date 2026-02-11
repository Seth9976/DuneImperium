using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.direction
{
	// Token: 0x020001A4 RID: 420
	[StructLayout(2)]
	public struct Direction3
	{
		// Token: 0x06001801 RID: 6145 RVA: 0x00073FBC File Offset: 0x000721BC
		// Note: this type is marked as 'beforefieldinit'.
		static Direction3()
		{
			Il2CppClassPointerStore<Direction3>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.direction", "Direction3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Direction3>.NativeClassPtr);
			Direction3.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Direction3>.NativeClassPtr, "X");
			Direction3.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Direction3>.NativeClassPtr, "Y");
			Direction3.NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Direction3>.NativeClassPtr, "Z");
			Direction3.NativeMethodInfoPtr_Equals_Public_Boolean_Direction3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Direction3>.NativeClassPtr, 100667110);
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0007403C File Offset: 0x0007223C
		[CallerCount(0)]
		public unsafe bool Equals(Direction3 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Direction3.NativeMethodInfoPtr_Equals_Public_Boolean_Direction3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x0000A89C File Offset: 0x00008A9C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Direction3>.NativeClassPtr, ref this));
		}

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeFieldInfoPtr_Z;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Direction3_0;

		// Token: 0x04001104 RID: 4356
		[FieldOffset(0)]
		public Direction X;

		// Token: 0x04001105 RID: 4357
		[FieldOffset(4)]
		public Direction Y;

		// Token: 0x04001106 RID: 4358
		[FieldOffset(8)]
		public Direction Z;

		// Token: 0x0200034D RID: 845
		[Serializable]
		public class Serializable : Object
		{
			// Token: 0x060026E7 RID: 9959 RVA: 0x000A57E8 File Offset: 0x000A39E8
			// Note: this type is marked as 'beforefieldinit'.
			static Serializable()
			{
				Il2CppClassPointerStore<Direction3.Serializable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Direction3>.NativeClassPtr, "Serializable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Direction3.Serializable>.NativeClassPtr);
				Direction3.Serializable.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Direction3.Serializable>.NativeClassPtr, "X");
				Direction3.Serializable.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Direction3.Serializable>.NativeClassPtr, "Y");
				Direction3.Serializable.NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Direction3.Serializable>.NativeClassPtr, "Z");
				Direction3.Serializable.NativeMethodInfoPtr_op_Implicit_Public_Static_Direction3_Serializable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Direction3.Serializable>.NativeClassPtr, 100667111);
				Direction3.Serializable.NativeMethodInfoPtr_op_Implicit_Public_Static_Serializable_Direction3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Direction3.Serializable>.NativeClassPtr, 100667112);
				Direction3.Serializable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Direction3.Serializable>.NativeClassPtr, 100667113);
			}

			// Token: 0x060026E8 RID: 9960 RVA: 0x000A588C File Offset: 0x000A3A8C
			[CallerCount(0)]
			public unsafe static implicit operator Direction3(Direction3.Serializable other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Direction3.Serializable.NativeMethodInfoPtr_op_Implicit_Public_Static_Direction3_Serializable_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060026E9 RID: 9961 RVA: 0x000A58D0 File Offset: 0x000A3AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879726, XrefRangeEnd = 879730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator Direction3.Serializable(Direction3 other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref other;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Direction3.Serializable.NativeMethodInfoPtr_op_Implicit_Public_Static_Serializable_Direction3_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Direction3.Serializable>(intPtr3) : null;
				}
			}

			// Token: 0x060026EA RID: 9962 RVA: 0x000A5910 File Offset: 0x000A3B10
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Serializable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Direction3.Serializable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Direction3.Serializable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026EB RID: 9963 RVA: 0x00011B45 File Offset: 0x0000FD45
			public Serializable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B04 RID: 2820
			// (get) Token: 0x060026EC RID: 9964 RVA: 0x000A594C File Offset: 0x000A3B4C
			// (set) Token: 0x060026ED RID: 9965 RVA: 0x00011B4E File Offset: 0x0000FD4E
			public unsafe Direction X
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Direction3.Serializable.NativeFieldInfoPtr_X);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Direction3.Serializable.NativeFieldInfoPtr_X)) = value;
				}
			}

			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x060026EE RID: 9966 RVA: 0x000A5974 File Offset: 0x000A3B74
			// (set) Token: 0x060026EF RID: 9967 RVA: 0x00011B69 File Offset: 0x0000FD69
			public unsafe Direction Y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Direction3.Serializable.NativeFieldInfoPtr_Y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Direction3.Serializable.NativeFieldInfoPtr_Y)) = value;
				}
			}

			// Token: 0x17000B06 RID: 2822
			// (get) Token: 0x060026F0 RID: 9968 RVA: 0x000A599C File Offset: 0x000A3B9C
			// (set) Token: 0x060026F1 RID: 9969 RVA: 0x00011B84 File Offset: 0x0000FD84
			public unsafe Direction Z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Direction3.Serializable.NativeFieldInfoPtr_Z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Direction3.Serializable.NativeFieldInfoPtr_Z)) = value;
				}
			}

			// Token: 0x04001A70 RID: 6768
			private static readonly IntPtr NativeFieldInfoPtr_X;

			// Token: 0x04001A71 RID: 6769
			private static readonly IntPtr NativeFieldInfoPtr_Y;

			// Token: 0x04001A72 RID: 6770
			private static readonly IntPtr NativeFieldInfoPtr_Z;

			// Token: 0x04001A73 RID: 6771
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Direction3_Serializable_0;

			// Token: 0x04001A74 RID: 6772
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Serializable_Direction3_0;

			// Token: 0x04001A75 RID: 6773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
