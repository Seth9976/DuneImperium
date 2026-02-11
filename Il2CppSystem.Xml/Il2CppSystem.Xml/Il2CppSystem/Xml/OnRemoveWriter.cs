using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000028 RID: 40
	public sealed class OnRemoveWriter : MulticastDelegate
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x0002094C File Offset: 0x0001EB4C
		// Note: this type is marked as 'beforefieldinit'.
		static OnRemoveWriter()
		{
			Il2CppClassPointerStore<OnRemoveWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "OnRemoveWriter");
			OnRemoveWriter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoveWriter>.NativeClassPtr, 100663669);
			OnRemoveWriter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoveWriter>.NativeClassPtr, 100663670);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0002099C File Offset: 0x0001EB9C
		[CallerCount(333)]
		[CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313209, XrefRangeStart = 312876, XrefRangeEnd = 313209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnRemoveWriter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnRemoveWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnRemoveWriter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000209F8 File Offset: 0x0001EBF8
		[CallerCount(0)]
		public unsafe void Invoke(XmlRawWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnRemoveWriter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XmlRawWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002FDE File Offset: 0x000011DE
		public OnRemoveWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002FE7 File Offset: 0x000011E7
		public static implicit operator OnRemoveWriter(Action<XmlRawWriter> A_0)
		{
			return DelegateSupport.ConvertDelegate<OnRemoveWriter>(A_0);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002FEF File Offset: 0x000011EF
		public static OnRemoveWriter operator +(OnRemoveWriter A_0, OnRemoveWriter A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<OnRemoveWriter>();
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002FFD File Offset: 0x000011FD
		public static OnRemoveWriter operator -(OnRemoveWriter A_0, OnRemoveWriter A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<OnRemoveWriter>();
			}
			return delegate2;
		}

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XmlRawWriter_0;
	}
}
