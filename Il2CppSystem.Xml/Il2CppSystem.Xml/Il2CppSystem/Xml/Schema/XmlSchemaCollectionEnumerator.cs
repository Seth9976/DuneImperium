using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A3 RID: 419
	public sealed class XmlSchemaCollectionEnumerator : Object
	{
		// Token: 0x06002493 RID: 9363 RVA: 0x000AD31C File Offset: 0x000AB51C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaCollectionEnumerator()
		{
			Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaCollectionEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr);
			XmlSchemaCollectionEnumerator.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr, "enumerator");
			XmlSchemaCollectionEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr, 100668597);
			XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr, 100668598);
			XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr, 100668599);
			XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr, 100668600);
			XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr, 100668601);
			XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_get_Current_Public_get_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr, 100668602);
			XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_get_CurrentNode_Internal_get_XmlSchemaCollectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr, 100668603);
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x000AD3EC File Offset: 0x000AB5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411216, XrefRangeEnd = 411219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaCollectionEnumerator(Hashtable collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaCollectionEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x000AD438 File Offset: 0x000AB638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411219, XrefRangeEnd = 411223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x000AD46C File Offset: 0x000AB66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411223, XrefRangeEnd = 411227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_IEnumerator_MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x000AD4A8 File Offset: 0x000AB6A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 411231, RefRangeEnd = 411232, XrefRangeStart = 411227, XrefRangeEnd = 411231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x000AD4E4 File Offset: 0x000AB6E4
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411232, XrefRangeEnd = 411233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x000AD524 File Offset: 0x000AB724
		public unsafe XmlSchema Current
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 411238, RefRangeEnd = 411240, XrefRangeStart = 411233, XrefRangeEnd = 411238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_get_Current_Public_get_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x000AD564 File Offset: 0x000AB764
		public unsafe XmlSchemaCollectionNode CurrentNode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 411245, RefRangeEnd = 411246, XrefRangeStart = 411240, XrefRangeEnd = 411245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionEnumerator.NativeMethodInfoPtr_get_CurrentNode_Internal_get_XmlSchemaCollectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaCollectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x0000F7AD File Offset: 0x0000D9AD
		public XmlSchemaCollectionEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x000AD5A4 File Offset: 0x000AB7A4
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x0000F7B6 File Offset: 0x0000D9B6
		public unsafe IDictionaryEnumerator enumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionEnumerator.NativeFieldInfoPtr_enumerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionEnumerator.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeFieldInfoPtr_enumerator;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_XmlSchema_0;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentNode_Internal_get_XmlSchemaCollectionNode_0;
	}
}
