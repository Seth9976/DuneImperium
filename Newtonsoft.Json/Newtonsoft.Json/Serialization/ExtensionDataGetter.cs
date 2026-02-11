using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000086 RID: 134
	public sealed class ExtensionDataGetter : MulticastDelegate
	{
		// Token: 0x06000AC4 RID: 2756 RVA: 0x00043B5C File Offset: 0x00041D5C
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionDataGetter()
		{
			Il2CppClassPointerStore<ExtensionDataGetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "ExtensionDataGetter");
			ExtensionDataGetter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionDataGetter>.NativeClassPtr, 100665332);
			ExtensionDataGetter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_KeyValuePair_2_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionDataGetter>.NativeClassPtr, 100665333);
			ExtensionDataGetter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionDataGetter>.NativeClassPtr, 100665334);
			ExtensionDataGetter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_KeyValuePair_2_Object_Object_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionDataGetter>.NativeClassPtr, 100665335);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00043BD4 File Offset: 0x00041DD4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 554431, RefRangeEnd = 554456, XrefRangeStart = 554431, XrefRangeEnd = 554456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtensionDataGetter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionDataGetter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionDataGetter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00043C30 File Offset: 0x00041E30
		[CallerCount(0)]
		public unsafe IEnumerable<KeyValuePair<Object, Object>> Invoke(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionDataGetter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_KeyValuePair_2_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Object, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00043C80 File Offset: 0x00041E80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Object o, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionDataGetter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00043CF4 File Offset: 0x00041EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<KeyValuePair<Object, Object>> EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionDataGetter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_KeyValuePair_2_Object_Object_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Object, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00005593 File Offset: 0x00003793
		public ExtensionDataGetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0000559C File Offset: 0x0000379C
		public static implicit operator ExtensionDataGetter(Func<Object, IEnumerable<KeyValuePair<Object, Object>>> A_0)
		{
			return DelegateSupport.ConvertDelegate<ExtensionDataGetter>(A_0);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000055A4 File Offset: 0x000037A4
		public static ExtensionDataGetter operator +(ExtensionDataGetter A_0, ExtensionDataGetter A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ExtensionDataGetter>();
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000055B2 File Offset: 0x000037B2
		public static ExtensionDataGetter operator -(ExtensionDataGetter A_0, ExtensionDataGetter A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ExtensionDataGetter>();
			}
			return delegate2;
		}

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_KeyValuePair_2_Object_Object_Object_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_AsyncCallback_Object_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_KeyValuePair_2_Object_Object_IAsyncResult_0;
	}
}
