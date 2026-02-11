using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Numerics;

namespace Il2CppSystem.Data
{
	// Token: 0x0200000A RID: 10
	public sealed class AutoIncrementInt64 : AutoIncrementValue
	{
		// Token: 0x060000EB RID: 235 RVA: 0x0000BC90 File Offset: 0x00009E90
		// Note: this type is marked as 'beforefieldinit'.
		static AutoIncrementInt64()
		{
			Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "AutoIncrementInt64");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr);
			AutoIncrementInt64.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, "_current");
			AutoIncrementInt64.NativeFieldInfoPtr__seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, "_seed");
			AutoIncrementInt64.NativeFieldInfoPtr__step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, "_step");
			AutoIncrementInt64.NativeMethodInfoPtr_get_Current_Internal_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663434);
			AutoIncrementInt64.NativeMethodInfoPtr_set_Current_Internal_Virtual_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663435);
			AutoIncrementInt64.NativeMethodInfoPtr_get_DataType_Internal_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663436);
			AutoIncrementInt64.NativeMethodInfoPtr_get_Seed_Internal_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663437);
			AutoIncrementInt64.NativeMethodInfoPtr_set_Seed_Internal_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663438);
			AutoIncrementInt64.NativeMethodInfoPtr_get_Step_Internal_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663439);
			AutoIncrementInt64.NativeMethodInfoPtr_set_Step_Internal_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663440);
			AutoIncrementInt64.NativeMethodInfoPtr_MoveAfter_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663441);
			AutoIncrementInt64.NativeMethodInfoPtr_SetCurrent_Internal_Virtual_Void_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663442);
			AutoIncrementInt64.NativeMethodInfoPtr_SetCurrentAndIncrement_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663443);
			AutoIncrementInt64.NativeMethodInfoPtr_BoundaryCheck_Private_Boolean_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663444);
			AutoIncrementInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr, 100663445);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000BDEC File Offset: 0x00009FEC
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000BE2C File Offset: 0x0000A02C
		public unsafe override Object Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888415, XrefRangeEnd = 888418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_get_Current_Internal_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888418, XrefRangeEnd = 888421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_set_Current_Internal_Virtual_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000BE70 File Offset: 0x0000A070
		public unsafe override Type DataType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888421, XrefRangeEnd = 888427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_get_DataType_Internal_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		public unsafe override long Seed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_get_Seed_Internal_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888427, XrefRangeEnd = 888432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_set_Seed_Internal_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000BF2C File Offset: 0x0000A12C
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000BF68 File Offset: 0x0000A168
		public unsafe override long Step
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_get_Step_Internal_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_set_Step_Internal_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		[CallerCount(0)]
		public unsafe override void MoveAfter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_MoveAfter_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000BFDC File Offset: 0x0000A1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888432, XrefRangeEnd = 888436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCurrent(Object value, IFormatProvider formatProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_SetCurrent_Internal_Virtual_Void_Object_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000C030 File Offset: 0x0000A230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888436, XrefRangeEnd = 888455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCurrentAndIncrement(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_SetCurrentAndIncrement_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000C074 File Offset: 0x0000A274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 888459, RefRangeEnd = 888461, XrefRangeStart = 888455, XrefRangeEnd = 888459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BoundaryCheck(BigInteger value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr_BoundaryCheck_Private_Boolean_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888461, XrefRangeEnd = 888462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoIncrementInt64()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoIncrementInt64>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000254A File Offset: 0x0000074A
		public AutoIncrementInt64(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000C104 File Offset: 0x0000A304
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002553 File Offset: 0x00000753
		public unsafe long _current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementInt64.NativeFieldInfoPtr__current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementInt64.NativeFieldInfoPtr__current)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000C12C File Offset: 0x0000A32C
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000256E File Offset: 0x0000076E
		public unsafe long _seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementInt64.NativeFieldInfoPtr__seed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementInt64.NativeFieldInfoPtr__seed)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000C154 File Offset: 0x0000A354
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002589 File Offset: 0x00000789
		public unsafe long _step
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementInt64.NativeFieldInfoPtr__step);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementInt64.NativeFieldInfoPtr__step)) = value;
			}
		}

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr__current;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr__seed;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr__step;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_Virtual_get_Object_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_set_Current_Internal_Virtual_set_Void_Object_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Internal_Virtual_get_Type_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_get_Seed_Internal_Virtual_get_Int64_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_set_Seed_Internal_Virtual_set_Void_Int64_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_get_Step_Internal_Virtual_get_Int64_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_set_Step_Internal_Virtual_set_Void_Int64_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_MoveAfter_Internal_Virtual_Void_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrent_Internal_Virtual_Void_Object_IFormatProvider_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentAndIncrement_Internal_Virtual_Void_Object_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_BoundaryCheck_Private_Boolean_BigInteger_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
