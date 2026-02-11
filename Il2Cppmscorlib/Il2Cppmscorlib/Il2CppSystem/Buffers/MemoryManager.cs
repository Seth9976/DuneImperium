using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Buffers
{
	// Token: 0x02000515 RID: 1301
	public class MemoryManager<T> : Object
	{
		// Token: 0x06004F95 RID: 20373 RVA: 0x001726F0 File Offset: 0x001708F0
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryManager()
		{
			Il2CppClassPointerStore<MemoryManager<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "MemoryManager`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryManager<T>>.NativeClassPtr);
			MemoryManager<T>.NativeMethodInfoPtr_GetSpan_Public_Abstract_Virtual_New_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryManager<T>>.NativeClassPtr, 100675299);
			MemoryManager<T>.NativeMethodInfoPtr_Pin_Public_Abstract_Virtual_New_MemoryHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryManager<T>>.NativeClassPtr, 100675300);
			MemoryManager<T>.NativeMethodInfoPtr_TryGetArray_FamOrAssem_Virtual_New_Boolean_byref_ArraySegment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryManager<T>>.NativeClassPtr, 100675301);
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x00172798 File Offset: 0x00170998
		[CallerCount(0)]
		public unsafe virtual Span<T> GetSpan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryManager<T>.NativeMethodInfoPtr_GetSpan_Public_Abstract_Virtual_New_Span_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Span<T>(intPtr);
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x001727DC File Offset: 0x001709DC
		[CallerCount(0)]
		public unsafe virtual MemoryHandle Pin(int elementIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryManager<T>.NativeMethodInfoPtr_Pin_Public_Abstract_Virtual_New_MemoryHandle_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MemoryHandle(intPtr);
			}
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x0017282C File Offset: 0x00170A2C
		[CallerCount(0)]
		public unsafe virtual bool TryGetArray(out ArraySegment<T> segment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryManager<T>.NativeMethodInfoPtr_TryGetArray_FamOrAssem_Virtual_New_Boolean_byref_ArraySegment_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				segment = ((intPtr4 == 0) ? null : new ArraySegment<T>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x0001C919 File Offset: 0x0001AB19
		public MemoryManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040040DE RID: 16606
		private static readonly IntPtr NativeMethodInfoPtr_GetSpan_Public_Abstract_Virtual_New_Span_1_T_0;

		// Token: 0x040040DF RID: 16607
		private static readonly IntPtr NativeMethodInfoPtr_Pin_Public_Abstract_Virtual_New_MemoryHandle_Int32_0;

		// Token: 0x040040E0 RID: 16608
		private static readonly IntPtr NativeMethodInfoPtr_TryGetArray_FamOrAssem_Virtual_New_Boolean_byref_ArraySegment_1_T_0;
	}
}
