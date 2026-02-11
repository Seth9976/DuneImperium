using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200014B RID: 331
	public sealed class WeakHashtable : Hashtable
	{
		// Token: 0x06001460 RID: 5216 RVA: 0x0006B2E4 File Offset: 0x000694E4
		// Note: this type is marked as 'beforefieldinit'.
		static WeakHashtable()
		{
			Il2CppClassPointerStore<WeakHashtable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "WeakHashtable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakHashtable>.NativeClassPtr);
			WeakHashtable.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakHashtable>.NativeClassPtr, "_comparer");
			WeakHashtable.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakHashtable>.NativeClassPtr, 100666336);
			WeakHashtable.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakHashtable>.NativeClassPtr, 100666337);
			WeakHashtable.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakHashtable>.NativeClassPtr, 100666338);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0006B364 File Offset: 0x00069564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465987, XrefRangeEnd = 465992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakHashtable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakHashtable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakHashtable.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0006B3A0 File Offset: 0x000695A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465992, XrefRangeEnd = 465993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakHashtable.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0006B3D4 File Offset: 0x000695D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465993, XrefRangeEnd = 466002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakHashtable.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00009121 File Offset: 0x00007321
		public WeakHashtable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x0006B418 File Offset: 0x00069618
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x0000912A File Offset: 0x0000732A
		public unsafe static IEqualityComparer _comparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WeakHashtable.NativeFieldInfoPtr__comparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WeakHashtable.NativeFieldInfoPtr__comparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0;

		// Token: 0x020002EA RID: 746
		public class WeakKeyComparer : Object
		{
			// Token: 0x06002CB5 RID: 11445 RVA: 0x000C4AD8 File Offset: 0x000C2CD8
			// Note: this type is marked as 'beforefieldinit'.
			static WeakKeyComparer()
			{
				Il2CppClassPointerStore<WeakHashtable.WeakKeyComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeakHashtable>.NativeClassPtr, "WeakKeyComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakHashtable.WeakKeyComparer>.NativeClassPtr);
				WeakHashtable.WeakKeyComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakHashtable.WeakKeyComparer>.NativeClassPtr, 100666340);
				WeakHashtable.WeakKeyComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakHashtable.WeakKeyComparer>.NativeClassPtr, 100666341);
				WeakHashtable.WeakKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakHashtable.WeakKeyComparer>.NativeClassPtr, 100666342);
			}

			// Token: 0x06002CB6 RID: 11446 RVA: 0x000C4B40 File Offset: 0x000C2D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465982, XrefRangeEnd = 465986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakHashtable.WeakKeyComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002CB7 RID: 11447 RVA: 0x000C4BA0 File Offset: 0x000C2DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465986, XrefRangeEnd = 465987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakHashtable.WeakKeyComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002CB8 RID: 11448 RVA: 0x000C4BF0 File Offset: 0x000C2DF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WeakKeyComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakHashtable.WeakKeyComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakHashtable.WeakKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CB9 RID: 11449 RVA: 0x0001422A File Offset: 0x0001242A
			public WeakKeyComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400233E RID: 9022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x0400233F RID: 9023
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x04002340 RID: 9024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
