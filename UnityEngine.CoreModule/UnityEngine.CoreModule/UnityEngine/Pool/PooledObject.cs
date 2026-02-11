using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Pool
{
	// Token: 0x020001D5 RID: 469
	public sealed class PooledObject<T> : ValueType where T : class
	{
		// Token: 0x0600212F RID: 8495 RVA: 0x0009244C File Offset: 0x0009064C
		// Note: this type is marked as 'beforefieldinit'.
		static PooledObject()
		{
			Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "PooledObject`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr);
			PooledObject<T>.NativeFieldInfoPtr_m_ToReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, "m_ToReturn");
			PooledObject<T>.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, "m_Pool");
			PooledObject<T>.NativeMethodInfoPtr__ctor_Public_Void_T_IObjectPool_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, 100667771);
			PooledObject<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, 100667772);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00092508 File Offset: 0x00090708
		[CallerCount(238)]
		[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PooledObject(T value, IObjectPool<T> pool)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pool);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PooledObject<T>.NativeMethodInfoPtr__ctor_Public_Void_T_IObjectPool_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x000925A0 File Offset: 0x000907A0
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 680847, RefRangeEnd = 680905, XrefRangeStart = 680842, XrefRangeEnd = 680847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PooledObject<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0000CB29 File Offset: 0x0000AD29
		public PooledObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x0000CB32 File Offset: 0x0000AD32
		public PooledObject()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x000925D8 File Offset: 0x000907D8
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x00092600 File Offset: 0x00090800
		public unsafe T m_ToReturn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_ToReturn);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_ToReturn);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x000926A8 File Offset: 0x000908A8
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x0000CB44 File Offset: 0x0000AD44
		public unsafe IObjectPool<T> m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_Pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IObjectPool<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeFieldInfoPtr_m_ToReturn;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_IObjectPool_1_T_0;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
	}
}
