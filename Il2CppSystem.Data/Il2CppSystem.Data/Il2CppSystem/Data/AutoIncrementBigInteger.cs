using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Numerics;

namespace Il2CppSystem.Data
{
	// Token: 0x0200000B RID: 11
	public sealed class AutoIncrementBigInteger : AutoIncrementValue
	{
		// Token: 0x060000FF RID: 255 RVA: 0x0000C17C File Offset: 0x0000A37C
		// Note: this type is marked as 'beforefieldinit'.
		static AutoIncrementBigInteger()
		{
			Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "AutoIncrementBigInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr);
			AutoIncrementBigInteger.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, "_current");
			AutoIncrementBigInteger.NativeFieldInfoPtr__seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, "_seed");
			AutoIncrementBigInteger.NativeFieldInfoPtr__step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, "_step");
			AutoIncrementBigInteger.NativeMethodInfoPtr_get_Current_Internal_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663446);
			AutoIncrementBigInteger.NativeMethodInfoPtr_set_Current_Internal_Virtual_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663447);
			AutoIncrementBigInteger.NativeMethodInfoPtr_get_DataType_Internal_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663448);
			AutoIncrementBigInteger.NativeMethodInfoPtr_get_Seed_Internal_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663449);
			AutoIncrementBigInteger.NativeMethodInfoPtr_set_Seed_Internal_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663450);
			AutoIncrementBigInteger.NativeMethodInfoPtr_get_Step_Internal_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663451);
			AutoIncrementBigInteger.NativeMethodInfoPtr_set_Step_Internal_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663452);
			AutoIncrementBigInteger.NativeMethodInfoPtr_MoveAfter_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663453);
			AutoIncrementBigInteger.NativeMethodInfoPtr_SetCurrent_Internal_Virtual_Void_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663454);
			AutoIncrementBigInteger.NativeMethodInfoPtr_SetCurrentAndIncrement_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663455);
			AutoIncrementBigInteger.NativeMethodInfoPtr_BoundaryCheck_Private_Boolean_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663456);
			AutoIncrementBigInteger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr, 100663457);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000C318 File Offset: 0x0000A518
		public unsafe override Object Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888462, XrefRangeEnd = 888465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_get_Current_Internal_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888465, XrefRangeEnd = 888471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_set_Current_Internal_Virtual_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000C35C File Offset: 0x0000A55C
		public unsafe override Type DataType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888471, XrefRangeEnd = 888477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_get_DataType_Internal_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000C39C File Offset: 0x0000A59C
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		public unsafe override long Seed
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_get_Seed_Internal_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888477, XrefRangeEnd = 888489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_set_Seed_Internal_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000C418 File Offset: 0x0000A618
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000C454 File Offset: 0x0000A654
		public unsafe override long Step
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888489, XrefRangeEnd = 888493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_get_Step_Internal_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888493, XrefRangeEnd = 888510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_set_Step_Internal_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000C494 File Offset: 0x0000A694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888510, XrefRangeEnd = 888515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveAfter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_MoveAfter_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888515, XrefRangeEnd = 888517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_SetCurrent_Internal_Virtual_Void_Object_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000C51C File Offset: 0x0000A71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888517, XrefRangeEnd = 888525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCurrentAndIncrement(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_SetCurrentAndIncrement_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000C560 File Offset: 0x0000A760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 888532, RefRangeEnd = 888534, XrefRangeStart = 888525, XrefRangeEnd = 888532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BoundaryCheck(BigInteger value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr_BoundaryCheck_Private_Boolean_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 888540, RefRangeEnd = 888543, XrefRangeStart = 888534, XrefRangeEnd = 888540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoIncrementBigInteger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoIncrementBigInteger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoIncrementBigInteger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000025A4 File Offset: 0x000007A4
		public AutoIncrementBigInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000C5F0 File Offset: 0x0000A7F0
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000025AD File Offset: 0x000007AD
		public BigInteger _current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementBigInteger.NativeFieldInfoPtr__current);
				return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementBigInteger.NativeFieldInfoPtr__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000C620 File Offset: 0x0000A820
		// (set) Token: 0x06000110 RID: 272 RVA: 0x000025DB File Offset: 0x000007DB
		public unsafe long _seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementBigInteger.NativeFieldInfoPtr__seed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementBigInteger.NativeFieldInfoPtr__seed)) = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000C648 File Offset: 0x0000A848
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000025F6 File Offset: 0x000007F6
		public BigInteger _step
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementBigInteger.NativeFieldInfoPtr__step);
				return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoIncrementBigInteger.NativeFieldInfoPtr__step), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr__current;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr__seed;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr__step;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_Virtual_get_Object_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_set_Current_Internal_Virtual_set_Void_Object_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Internal_Virtual_get_Type_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_get_Seed_Internal_Virtual_get_Int64_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_set_Seed_Internal_Virtual_set_Void_Int64_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_get_Step_Internal_Virtual_get_Int64_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_set_Step_Internal_Virtual_set_Void_Int64_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_MoveAfter_Internal_Virtual_Void_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrent_Internal_Virtual_Void_Object_IFormatProvider_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentAndIncrement_Internal_Virtual_Void_Object_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_BoundaryCheck_Private_Boolean_BigInteger_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
