using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200007F RID: 127
	public sealed class ByRefParameterExpression : TypedParameterExpression
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x0002EBF8 File Offset: 0x0002CDF8
		// Note: this type is marked as 'beforefieldinit'.
		static ByRefParameterExpression()
		{
			Il2CppClassPointerStore<ByRefParameterExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ByRefParameterExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByRefParameterExpression>.NativeClassPtr);
			ByRefParameterExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefParameterExpression>.NativeClassPtr, 100664607);
			ByRefParameterExpression.NativeMethodInfoPtr_GetIsByRef_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByRefParameterExpression>.NativeClassPtr, 100664608);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0002EC50 File Offset: 0x0002CE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014660, XrefRangeEnd = 1014661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByRefParameterExpression(Type type, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByRefParameterExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByRefParameterExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0002ECB0 File Offset: 0x0002CEB0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetIsByRef()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByRefParameterExpression.NativeMethodInfoPtr_GetIsByRef_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00003A9A File Offset: 0x00001C9A
		public ByRefParameterExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_GetIsByRef_Internal_Virtual_Boolean_0;
	}
}
