using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000143 RID: 323
	[Serializable]
	public sealed class LazyLoadReference<T> : ValueType where T : Object
	{
		// Token: 0x060018C5 RID: 6341 RVA: 0x00074954 File Offset: 0x00072B54
		// Note: this type is marked as 'beforefieldinit'.
		static LazyLoadReference()
		{
			Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LazyLoadReference`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr);
			LazyLoadReference<T>.NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, "m_InstanceID");
			LazyLoadReference<T>.NativeMethodInfoPtr_get_asset_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, 100666703);
			LazyLoadReference<T>.NativeMethodInfoPtr_set_asset_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr, 100666704);
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x000749FC File Offset: 0x00072BFC
		// (set) Token: 0x060018C7 RID: 6343 RVA: 0x00074A3C File Offset: 0x00072C3C
		public unsafe T asset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666400, XrefRangeEnd = 666408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyLoadReference<T>.NativeMethodInfoPtr_get_asset_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 666416, RefRangeEnd = 666417, XrefRangeStart = 666408, XrefRangeEnd = 666416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyLoadReference<T>.NativeMethodInfoPtr_set_asset_Public_set_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00009B7A File Offset: 0x00007D7A
		public LazyLoadReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00009B83 File Offset: 0x00007D83
		public LazyLoadReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyLoadReference<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x00074ABC File Offset: 0x00072CBC
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x00009B95 File Offset: 0x00007D95
		public unsafe int m_InstanceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyLoadReference<T>.NativeFieldInfoPtr_m_InstanceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyLoadReference<T>.NativeFieldInfoPtr_m_InstanceID)) = value;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00009BB0 File Offset: 0x00007DB0
		public bool isSet
		{
			get
			{
				return this.m_InstanceID != 0;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x00009BBB File Offset: 0x00007DBB
		public bool isBroken
		{
			get
			{
				return this.m_InstanceID != 0 && !Object.DoesObjectWithInstanceIDExist(this.m_InstanceID);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x00009BD6 File Offset: 0x00007DD6
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x00009BDE File Offset: 0x00007DDE
		public int instanceID
		{
			get
			{
				return this.m_InstanceID;
			}
			set
			{
				this.m_InstanceID = value;
			}
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00074AE4 File Offset: 0x00072CE4
		public static implicit operator LazyLoadReference<T>(T asset)
		{
			LazyLoadReference<T> lazyLoadReference = null;
			lazyLoadReference.asset = asset;
			return lazyLoadReference;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00074B08 File Offset: 0x00072D08
		public new static implicit operator LazyLoadReference<T>(int instanceID)
		{
			LazyLoadReference<T> lazyLoadReference = null;
			lazyLoadReference.instanceID = instanceID;
			return lazyLoadReference;
		}

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceID;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_get_T_0;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeMethodInfoPtr_set_asset_Public_set_Void_T_0;

		// Token: 0x04001622 RID: 5666
		public const int kInstanceID_None = 0;
	}
}
