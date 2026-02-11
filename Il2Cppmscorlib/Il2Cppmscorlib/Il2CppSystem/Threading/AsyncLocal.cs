using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000182 RID: 386
	public sealed class AsyncLocal<T> : Object
	{
		// Token: 0x060019DB RID: 6619 RVA: 0x0009F90C File Offset: 0x0009DB0C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncLocal()
		{
			Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AsyncLocal`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr);
			AsyncLocal<T>.NativeFieldInfoPtr_m_valueChangedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, "m_valueChangedHandler");
			AsyncLocal<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100667824);
			AsyncLocal<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100667825);
			AsyncLocal<T>.NativeMethodInfoPtr_System_Threading_IAsyncLocal_OnValueChanged_Private_Virtual_Final_New_Void_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100667826);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0009F9C8 File Offset: 0x0009DBC8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncLocal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000495 RID: 1173
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x0009FA04 File Offset: 0x0009DC04
		public unsafe T Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1351491, RefRangeEnd = 1351492, XrefRangeStart = 1351487, XrefRangeEnd = 1351491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0009FA7C File Offset: 0x0009DC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351492, XrefRangeEnd = 1351499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Threading_IAsyncLocal_OnValueChanged(Object previousValueObj, Object currentValueObj, bool contextChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousValueObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValueObj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr_System_Threading_IAsyncLocal_OnValueChanged_Private_Virtual_Final_New_Void_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00008384 File Offset: 0x00006584
		public AsyncLocal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0009FAE0 File Offset: 0x0009DCE0
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0000838D File Offset: 0x0000658D
		public unsafe Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocal<T>.NativeFieldInfoPtr_m_valueChangedHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncLocalValueChangedArgs<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocal<T>.NativeFieldInfoPtr_m_valueChangedHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeFieldInfoPtr_m_valueChangedHandler;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_T_0;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IAsyncLocal_OnValueChanged_Private_Virtual_Final_New_Void_Object_Object_Boolean_0;
	}
}
