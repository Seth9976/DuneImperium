using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000025 RID: 37
	public class IDtdParserAdapter : Il2CppObjectBase
	{
		// Token: 0x0600028C RID: 652 RVA: 0x0001FCD4 File Offset: 0x0001DED4
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdParserAdapter()
		{
			Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdParserAdapter");
			IDtdParserAdapter.NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663639);
			IDtdParserAdapter.NativeMethodInfoPtr_get_NamespaceResolver_Public_Abstract_Virtual_New_get_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663640);
			IDtdParserAdapter.NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663641);
			IDtdParserAdapter.NativeMethodInfoPtr_get_ParsingBuffer_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663642);
			IDtdParserAdapter.NativeMethodInfoPtr_get_ParsingBufferLength_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663643);
			IDtdParserAdapter.NativeMethodInfoPtr_get_CurrentPosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663644);
			IDtdParserAdapter.NativeMethodInfoPtr_set_CurrentPosition_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663645);
			IDtdParserAdapter.NativeMethodInfoPtr_get_LineNo_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663646);
			IDtdParserAdapter.NativeMethodInfoPtr_get_LineStartPosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663647);
			IDtdParserAdapter.NativeMethodInfoPtr_get_IsEof_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663648);
			IDtdParserAdapter.NativeMethodInfoPtr_get_EntityStackLength_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663649);
			IDtdParserAdapter.NativeMethodInfoPtr_get_IsEntityEolNormalized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663650);
			IDtdParserAdapter.NativeMethodInfoPtr_ReadData_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663651);
			IDtdParserAdapter.NativeMethodInfoPtr_OnNewLine_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663652);
			IDtdParserAdapter.NativeMethodInfoPtr_ParseNumericCharRef_Public_Abstract_Virtual_New_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663653);
			IDtdParserAdapter.NativeMethodInfoPtr_ParseNamedCharRef_Public_Abstract_Virtual_New_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663654);
			IDtdParserAdapter.NativeMethodInfoPtr_ParsePI_Public_Abstract_Virtual_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663655);
			IDtdParserAdapter.NativeMethodInfoPtr_ParseComment_Public_Abstract_Virtual_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663656);
			IDtdParserAdapter.NativeMethodInfoPtr_PushEntity_Public_Abstract_Virtual_New_Boolean_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663657);
			IDtdParserAdapter.NativeMethodInfoPtr_PopEntity_Public_Abstract_Virtual_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663658);
			IDtdParserAdapter.NativeMethodInfoPtr_PushExternalSubset_Public_Abstract_Virtual_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663659);
			IDtdParserAdapter.NativeMethodInfoPtr_PushInternalDtd_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663660);
			IDtdParserAdapter.NativeMethodInfoPtr_OnSystemId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663661);
			IDtdParserAdapter.NativeMethodInfoPtr_OnPublicId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663662);
			IDtdParserAdapter.NativeMethodInfoPtr_Throw_Public_Abstract_Virtual_New_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapter>.NativeClassPtr, 100663663);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		public unsafe virtual XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0001FF3C File Offset: 0x0001E13C
		public unsafe virtual IXmlNamespaceResolver NamespaceResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_NamespaceResolver_Public_Abstract_Virtual_New_get_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr3) : null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0001FF88 File Offset: 0x0001E188
		public unsafe virtual Uri BaseUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
		public unsafe virtual Il2CppStructArray<char> ParsingBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_ParsingBuffer_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00020020 File Offset: 0x0001E220
		public unsafe virtual int ParsingBufferLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_ParsingBufferLength_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00020068 File Offset: 0x0001E268
		// (set) Token: 0x06000293 RID: 659 RVA: 0x000200B0 File Offset: 0x0001E2B0
		public unsafe virtual int CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_CurrentPosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_set_CurrentPosition_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000200FC File Offset: 0x0001E2FC
		public unsafe virtual int LineNo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_LineNo_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00020144 File Offset: 0x0001E344
		public unsafe virtual int LineStartPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_LineStartPosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0002018C File Offset: 0x0001E38C
		public unsafe virtual bool IsEof
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_IsEof_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000201D4 File Offset: 0x0001E3D4
		public unsafe virtual int EntityStackLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_EntityStackLength_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0002021C File Offset: 0x0001E41C
		public unsafe virtual bool IsEntityEolNormalized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_get_IsEntityEolNormalized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00020264 File Offset: 0x0001E464
		[CallerCount(0)]
		public unsafe virtual int ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_ReadData_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000202AC File Offset: 0x0001E4AC
		[CallerCount(0)]
		public unsafe virtual void OnNewLine(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_OnNewLine_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000202F8 File Offset: 0x0001E4F8
		[CallerCount(0)]
		public unsafe virtual int ParseNumericCharRef(StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_ParseNumericCharRef_Public_Abstract_Virtual_New_Int32_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00020350 File Offset: 0x0001E550
		[CallerCount(0)]
		public unsafe virtual int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_ParseNamedCharRef_Public_Abstract_Virtual_New_Int32_Boolean_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000203B8 File Offset: 0x0001E5B8
		[CallerCount(0)]
		public unsafe virtual void ParsePI(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_ParsePI_Public_Abstract_Virtual_New_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00020408 File Offset: 0x0001E608
		[CallerCount(0)]
		public unsafe virtual void ParseComment(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_ParseComment_Public_Abstract_Virtual_New_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00020458 File Offset: 0x0001E658
		[CallerCount(0)]
		public unsafe virtual bool PushEntity(IDtdEntityInfo entity, out int entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_PushEntity_Public_Abstract_Virtual_New_Boolean_IDtdEntityInfo_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000204C0 File Offset: 0x0001E6C0
		[CallerCount(0)]
		public unsafe virtual bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &newEntityId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_PopEntity_Public_Abstract_Virtual_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			oldEntity = ((intPtr4 == 0) ? null : new IDtdEntityInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00020538 File Offset: 0x0001E738
		[CallerCount(0)]
		public unsafe virtual bool PushExternalSubset(string systemId, string publicId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_PushExternalSubset_Public_Abstract_Virtual_New_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000205A4 File Offset: 0x0001E7A4
		[CallerCount(0)]
		public unsafe virtual void PushInternalDtd(string baseUri, string internalDtd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalDtd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_PushInternalDtd_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00020604 File Offset: 0x0001E804
		[CallerCount(0)]
		public unsafe virtual void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref systemLiteralLineInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_OnSystemId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00020670 File Offset: 0x0001E870
		[CallerCount(0)]
		public unsafe virtual void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publicLiteralLineInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_OnPublicId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000206DC File Offset: 0x0001E8DC
		[CallerCount(0)]
		public unsafe virtual void Throw(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapter.NativeMethodInfoPtr_Throw_Public_Abstract_Virtual_New_Void_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002FC3 File Offset: 0x000011C3
		public IDtdParserAdapter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceResolver_Public_Abstract_Virtual_New_get_IXmlNamespaceResolver_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Public_Abstract_Virtual_New_get_Uri_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingBuffer_Public_Abstract_Virtual_New_get_Il2CppStructArray_1_Char_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingBufferLength_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPosition_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_get_LineStartPosition_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEof_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityStackLength_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEntityEolNormalized_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_OnNewLine_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumericCharRef_Public_Abstract_Virtual_New_Int32_StringBuilder_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_ParseNamedCharRef_Public_Abstract_Virtual_New_Int32_Boolean_StringBuilder_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Public_Abstract_Virtual_New_Void_StringBuilder_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_ParseComment_Public_Abstract_Virtual_New_Void_StringBuilder_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_PushEntity_Public_Abstract_Virtual_New_Boolean_IDtdEntityInfo_byref_Int32_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_PopEntity_Public_Abstract_Virtual_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_PushExternalSubset_Public_Abstract_Virtual_New_Boolean_String_String_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_PushInternalDtd_Public_Abstract_Virtual_New_Void_String_String_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_OnSystemId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_OnPublicId_Public_Abstract_Virtual_New_Void_String_LineInfo_LineInfo_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Public_Abstract_Virtual_New_Void_Exception_0;
	}
}
