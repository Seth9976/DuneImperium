using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005A RID: 90
	public sealed class CachingEventHandler : MulticastDelegate
	{
		// Token: 0x06000AB4 RID: 2740 RVA: 0x000446C8 File Offset: 0x000428C8
		// Note: this type is marked as 'beforefieldinit'.
		static CachingEventHandler()
		{
			Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "CachingEventHandler");
			CachingEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr, 100665081);
			CachingEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdCachingReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr, 100665082);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00044718 File Offset: 0x00042918
		[CallerCount(333)]
		[CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313209, XrefRangeStart = 312876, XrefRangeEnd = 313209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachingEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachingEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00044774 File Offset: 0x00042974
		[CallerCount(0)]
		public unsafe void Invoke(XsdCachingReader cachingReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachingReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachingEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdCachingReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0000583C File Offset: 0x00003A3C
		public CachingEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00005845 File Offset: 0x00003A45
		public static implicit operator CachingEventHandler(Action<XsdCachingReader> A_0)
		{
			return DelegateSupport.ConvertDelegate<CachingEventHandler>(A_0);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000584D File Offset: 0x00003A4D
		public static CachingEventHandler operator +(CachingEventHandler A_0, CachingEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CachingEventHandler>();
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0000585B File Offset: 0x00003A5B
		public static CachingEventHandler operator -(CachingEventHandler A_0, CachingEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CachingEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdCachingReader_0;
	}
}
